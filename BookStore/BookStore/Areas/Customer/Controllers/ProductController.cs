using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProductController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            var productVM = new ProductVM
            {
                Book = await _unitOfWork.Book.GetFirstOrDefaultAsync(b => b.BookId == id, b => b.Category),
                BooksBestSellers = _unitOfWork.Book.GetAllAsync(b => b.Price > 0).Result.Select(b => new Book
                {
                    BookId = b.BookId,
                    Title = b.Title,
                    Price = b.Price,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl
                }).Take(5),
                Categories = _unitOfWork.Category.GetAllAsync().Result.Take(10)
            };

            var discountPrice = productVM.Book.Price * Convert.ToDouble(productVM.Book.DiscountRate) / 100;
            productVM.Book.OfferingPrice = productVM.Book.Price - discountPrice;

            return View(productVM);
        }

        #region APIs
        [HttpPost]
        public async Task<IActionResult> Cart(Guid bookId)
        {
            if (bookId == Guid.Empty)
                return Json(new { success = false });

            var user = await _userManager.GetUserAsync(User);
            var cart = new Cart()
            {
                BookId = bookId,
                UserId = await _userManager.GetUserIdAsync(user),
                Count = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            await _unitOfWork.Cart.AddAsync(cart);
            await _unitOfWork.SaveAsync();

            return Json(new { success = true });
        }
        #endregion
    }
}
