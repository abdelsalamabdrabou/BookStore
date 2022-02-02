using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
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
            var book = await _unitOfWork.Book.GetFirstOrDefaultAsync(b => b.BookId == id, b => b.Category);
            var discountPrice = book.Price * Convert.ToDouble(book.DiscountRate) / 100;
            book.OfferingPrice = book.Price - discountPrice;

            return View(book);
        }
    }
}
