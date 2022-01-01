using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Utility.ConstantsStringSettings;
using BookStore.Utility.Uploader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ImageUploader imageUploader;
        public BookController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            imageUploader = new ImageUploader(hostEnvironment);
        }

        public async Task<IActionResult> Index(Guid id, string isbn)
        {
            if (id != Guid.Empty && isbn != null)
            {
                var getBookFromDb = await _unitOfWork.Book.GetByIdAsync(id, isbn);
                return View(getBookFromDb);
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Book book)
        {
            ModelState.Remove("BookId");
            if (ModelState.IsValid)
            {
                if (book.BookId == Guid.Empty)
                {
                    var files = HttpContext.Request.Form.Files;
                    book.ImageUrl = await imageUploader.Uplaod(files, FolderPaths.book);
                    await _unitOfWork.Book.AddAsync(book);
                }
                
                else
                    await _unitOfWork.Book.UpdateAsync(book);

                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(nameof(Index));
        }
    }
}
