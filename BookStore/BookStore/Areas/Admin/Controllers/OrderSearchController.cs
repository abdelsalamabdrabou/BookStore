using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    public partial class OrderController : Controller
    {
        [TempData]
        public string ErrorMessage { get; set; }
        public IActionResult Search()
        {
            Search search = new();
            return View(search);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(Search search)
        {
            if (ModelState.IsValid)
            {
                string trackingNumber = search.Value;
                OrderHeader orderHeader = await _unitOfWork.OrderHeader.GetFirstOrDefaultAsync(o => o.TrackingNumber == trackingNumber);

                if (orderHeader != null)
                    return RedirectToAction(nameof(Details), new { id = orderHeader.OrderId });

                search = new()
                {
                    ErrorMessage = "This tracking number is not exists."
                };

                return View(search);
            }

            search = new();
            return View(search);
        }
    }
}
