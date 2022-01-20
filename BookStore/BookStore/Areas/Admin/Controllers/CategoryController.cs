using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.ViewModels;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area(UserAreas.Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public CategoryViewModel CategoryVM { get; set; }
        public async Task<IActionResult> Index(int id)
        {
            CategoryVM = new CategoryViewModel()
            {
                Category = (id == 0) ? new Category() : await _unitOfWork.Category.GetByIdAsync(id),
                Categories = await _unitOfWork.Category.GetAllAsync()
            };

            return View(CategoryVM);
        } 

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Upsert()
        {
            if (ModelState.IsValid)
            {
                if (CategoryVM.Category.CategoryId == 0)
                    await _unitOfWork.Category.AddAsync(CategoryVM.Category);
                else
                    await _unitOfWork.Category.UpdateAsync(CategoryVM.Category);

                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }

            CategoryVM.Categories = await _unitOfWork.Category.GetAllAsync();
            return View(nameof(Index), CategoryVM);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var getObjFromDb = await _unitOfWork.Category.GetByIdAsync(id);
            if (getObjFromDb != null)
            {
                _unitOfWork.Category.Remove(getObjFromDb);
                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
