using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Mvc;
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

            return View(orderConfirmationVM);   
        }
    }
}
