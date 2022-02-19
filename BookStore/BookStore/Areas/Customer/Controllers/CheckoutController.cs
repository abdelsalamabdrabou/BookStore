using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CheckoutController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private static string userId;
        public CheckoutController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

                await ConfigureOrderHeader(orderHeader);
                await ConfigureOrderDetail(carts, orderHeader.OrderId);

                await _unitOfWork.SaveAsync();

                return RedirectToAction("Index", "Home");
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
            orderHeader.TrackingNumber = GenerateTrackingNumber();
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

        public string GenerateTrackingNumber()
        {
            Random _random = new();
            int num = _random.Next(1000, 1000000);
            string generateUniqueId = Guid.NewGuid().ToString();
            string uniqueId = generateUniqueId[..8];
            string trackingNumber = string.Format("{0}-{1}", num, uniqueId);

            return trackingNumber;
        }
    }
}
