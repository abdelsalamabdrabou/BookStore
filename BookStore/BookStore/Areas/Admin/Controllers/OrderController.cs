using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area(UserAreas.Admin)]
    public partial class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var order = await _unitOfWork.OrderHeader.GetFirstOrDefaultAsync(o => o.OrderId == id, o => o.User);

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(OrderHeader orderHeader)
        {
            await _unitOfWork.OrderHeader.UpdateAsync(orderHeader);
            await _unitOfWork.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        #region APIs
        public IActionResult GetOrders()
        {
            var getOrdersFromDb = _unitOfWork.OrderHeader.GetAllAsync(null, o => o.User).Result.Select(o => new
            {
                orderId = o.OrderId,
                trackingNumber = o.TrackingNumber,
                customer = o.UserId,
                orderStatus = o.OrderStatus,
                paymentStatus = o.PaymentStatus,
                processedBy = o.ProcessedBy
            });

            return Json(new { data = getOrdersFromDb });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getOrderFromDb = await _unitOfWork.OrderHeader.GetByIdAsync(id);
            if (getOrderFromDb == null)
                return Json(new { success = false });

            _unitOfWork.OrderHeader.Remove(getOrderFromDb);
            await _unitOfWork.SaveAsync();
            return Json(new { success = true });
        }
        #endregion
    }
}
