using BookStore.Data;
using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository
{
    public class CategoryRepository : RepositoryAsync<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(Category category)
        {
            var objectFromDb = await _db.Categories.FindAsync(category.CategoryId);
            if (objectFromDb != null)
            {
                objectFromDb.Name = category.Name;
                objectFromDb.Description = category.Description;
            }
        }
    }
}
