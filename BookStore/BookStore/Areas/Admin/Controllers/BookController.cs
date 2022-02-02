using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using BookStore.Utility.Uploader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area(UserAreas.Admin)]
    public class BookController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ImageUploader imageUploader;
        private readonly IEnumerable<SelectListItem> categoryList;
        public BookController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            imageUploader = new ImageUploader(hostEnvironment);
            categoryList = _unitOfWork.Category.GetAllAsync().Result.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.CategoryId.ToString()
            });
        }

        [Authorize(ModulesPermissions.BOOK_CREATE)]
        public async Task<IActionResult> Index(Guid id)
        {
            var bookVM = new BookVM()
            {
                Book = new Book(),
                CategoryList = categoryList
            };

            if (id != Guid.Empty)
            {
                bookVM.Book = await _unitOfWork.Book.GetFirstOrDefaultAsync(b => b.BookId == id, b => b.Category);
                return View(bookVM);
            }

            return View(bookVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(ModulesPermissions.BOOK_CREATE)]
        public async Task<IActionResult> Add(BookVM bookVM)
        {
            ModelState.Remove("BookId");
            if (ModelState.IsValid)
            {
                if (bookVM.Book.BookId == Guid.Empty)
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0)
                        bookVM.Book.ImageUrl = await imageUploader.Upload(files, FolderPaths.book);

                    await _unitOfWork.Book.AddAsync(bookVM.Book);
                    await _unitOfWork.SaveAsync();
                    return RedirectToAction(nameof(ExistingBooks));
                }
            }

            bookVM.CategoryList = categoryList;
            return View(nameof(Index), bookVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(ModulesPermissions.BOOK_UPDATE)]
        public async Task<IActionResult> Update(BookVM bookVM)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                var previousImageUrl = _unitOfWork.Book.GetByIdAsync(bookVM.Book.BookId).Result.ImageUrl;

                if (files.Count > 0)
                {
                    imageUploader.Delete(previousImageUrl);
                    bookVM.Book.ImageUrl = await imageUploader.Upload(files, FolderPaths.book);
                }

                else
                    bookVM.Book.ImageUrl = previousImageUrl;

                await _unitOfWork.Book.UpdateAsync(bookVM.Book);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(ExistingBooks));
            }

            bookVM.CategoryList = categoryList;
            return View(nameof(Index), bookVM);
        }

        [Authorize(ModulesPermissions.BOOK_VIEW)]
        public IActionResult ExistingBooks()
        {
            return View();
        }

        #region APIs
        [HttpGet]
        public IActionResult GetBooks()
        {
            var getBooksFromDb = _unitOfWork.Book.GetAllAsync().Result.Select(b => new
            {
                bookId = b.BookId,
                isbn = b.ISBN,
                title = b.Title,
                author = b.Author,
                publisher = b.Publisher,
				price = b.Price,
                discountRate = b.DiscountRate,
                edition = b.Edition,
                publicationYear = b.PublicationYear,
                status = b.Status,
                quantity = b.Quantity
            });

            return Json(new { data = getBooksFromDb });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var getBookFromDb = await _unitOfWork.Book.GetByIdAsync(id);
            if (getBookFromDb == null)
                return Json (new { success = false });

            _unitOfWork.Book.Remove(getBookFromDb);
            await _unitOfWork.SaveAsync();
            return Json(new {success = true });
        }
        #endregion
    }
}
