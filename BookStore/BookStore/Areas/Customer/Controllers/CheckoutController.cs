using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using BookStore.Utility.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _host;
        private static string userId;
        public CheckoutController(IUnitOfWork unitOfWork, IWebHostEnvironment host)
        {
            _unitOfWork = unitOfWork;
            _host = host;
        }
        
        public IActionResult Index()
        {
            userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            OrderVM orderVM = InitOrderVM(); 

            return View(orderVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(OrderVM orderVM)
        {
            if (ModelState.IsValid)
            {
                var orderHeader = orderVM.OrderHeader;
                var carts = orderVM.Carts;

                // Order
                await ConfigureOrderHeader(orderHeader);
                await ConfigureOrderDetail(carts, orderHeader.OrderId);

                // Payment
                CreateCheckoutSession(carts, orderHeader);

                await _unitOfWork.SaveAsync();
                return new StatusCodeResult(303);
            }

            orderVM = InitOrderVM();
            return View(orderVM);
        }

        public OrderVM InitOrderVM()
        {
            OrderVM orderVM = new()
            {
                OrderHeader = new(),
                Carts = _unitOfWork.Cart.GetAllAsync(c => c.UserId == userId, c => c.Book).Result.Select(c => new CartVM
                {
                    BookId = c.BookId,
                    Price = c.Book.DiscountRate < 0 ? c.Book.Price : c.Book.Price - (c.Book.Price * c.Book.DiscountRate / 100),
                    Title = c.Book.Title,
                    Count = c.Count,
                }).ToList()
            };

            return orderVM;
        }

        public async Task ConfigureOrderHeader(OrderHeader orderHeader)
        {
            orderHeader.OrderStatus = Status.Pending.ToString();
            orderHeader.OrderDate = DateTime.Now;
            orderHeader.PaymentStatus = Status.Pending.ToString();
            orderHeader.PaymentDate = DateTime.Now;
            orderHeader.TrackingNumber = Tracking.GenerateNumber();
            orderHeader.UserId = userId;

            await _unitOfWork.OrderHeader.AddAsync(orderHeader);
        }

        public async Task ConfigureOrderDetail(List<CartVM> carts, Guid orderId)
        {
            var orderDetails = new List<OrderDetail>();

            foreach(var cart in carts)
                orderDetails.Add(new OrderDetail
                {
                    Count = cart.Count,
                    Price = cart.Price, 
                    BookId = cart.BookId, 
                    OrderId = orderId
                });
          
            await _unitOfWork.OrderDetail.AddRangeAsync(orderDetails);
        }

        public void CreateCheckoutSession(List<CartVM> carts, OrderHeader orderHeader)
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                    {
                      "card",
                    },
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                SuccessUrl = string.Format("https://{0}{1}?id={2}", Request.Host.Value, "OrderConfirmation", orderHeader.OrderId),
                CancelUrl = string.Format("https://{0}{1}", Request.Host.Value, Request.Path.Value),
            };

            foreach (var cart in carts)
            {
                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(cart.Price * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = cart.Title
                        },

                    },
                    Quantity = cart.Count
                };

                options.LineItems.Add(sessionLineItem);
            }

            var service = new SessionService();
            Session session = service.Create(options);

            orderHeader.SessionId = session.Id;
            orderHeader.TransactionId = session.PaymentIntentId;

            Response.Headers.Add("Location", session.Url);
        }
    }
}
