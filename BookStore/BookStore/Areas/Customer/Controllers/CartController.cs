using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public CartController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var carts = _unitOfWork.Cart.GetAllAsync(c => c.UserId == user.Id, c => c.Book).Result.OrderByDescending(c => c.CreatedDate);

            return View(carts);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Cart cart)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Cart.UpdateAsync(cart);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var cartModel = await _unitOfWork.Cart.GetFirstOrDefaultAsync(c => c.CartId == cart.CartId);
                return View(cartModel);
            }
        }


        #region APIs
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cart = await _unitOfWork.Cart.GetByIdAsync(id);

            if (cart == null)
                return Json(new { success = false });

            _unitOfWork.Cart.Remove(cart);
            await _unitOfWork.SaveAsync();

            return Json(new { success = true });
        }
        #endregion
    }
}
