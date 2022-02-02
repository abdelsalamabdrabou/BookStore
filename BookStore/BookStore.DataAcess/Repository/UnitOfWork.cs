using BookStore.Data;
using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Book = new BookRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db, _userManager);
        }

        public ICategoryRepository Category { get; private set; }
        public IBookRepoistory Book { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public async Task DisposeAsync()
        {
            await _db.DisposeAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
