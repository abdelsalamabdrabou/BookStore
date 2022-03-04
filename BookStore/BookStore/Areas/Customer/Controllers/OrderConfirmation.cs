using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Customer.Controllers
{
    [Area(UserAreas.Customer)]
    public class OrderConfirmation : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderConfirmation(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            var orderHeader = await _unitOfWork.OrderHeader.GetFirstOrDefaultAsync(o => o.OrderId == id);

            if (orderHeader.PaymentStatus == Status.Pending.ToString())
                await ApprovePayment(orderHeader);

            OrderConfirmationVM orderConfirmationVM = InitOrderConfirmationVM(id, orderHeader);
            return View(orderConfirmationVM);
        }

        public OrderConfirmationVM InitOrderConfirmationVM(Guid id, OrderHeader orderHeader)
        {
            var orderConfirmationVM = new OrderConfirmationVM()
            {
                OrderId = id.ToString(),
                TrackingNumber = orderHeader.TrackingNumber,
                Items = _unitOfWork.OrderDetail.GetAllAsync(o => o.OrderId == id, o => o.Book).Result.Select(o => new OrderConfirmationItems
                {
                    Title = o.Book.Title,
                    Price = o.Price,
                    Count = o.Count
                }).ToList(),
                Total = orderHeader.TotalOrder,
                Address = $"{orderHeader.Street}, { orderHeader.State}, { orderHeader.City}"
            };

            return orderConfirmationVM;
        }

        public async Task RemoveCarts(string userId)
        {
            var carts = await _unitOfWork.Cart.GetAllAsync(c => c.UserId == userId.ToString());
            _unitOfWork.Cart.RemoveRange(carts);
        }

        public async Task ApprovePayment(OrderHeader orderHeader)
        {
            var service = new SessionService();
            Session session = await service.GetAsync(orderHeader.SessionId);

            if (session.PaymentStatus == Status.Paid.ToString().ToLower())
            {
                await _unitOfWork.OrderHeader.UpdateAsync(orderHeader, Status.Approved.ToString(), Status.Approved.ToString());
                await RemoveCarts(orderHeader.UserId);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
