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
    public class ApplicationUserRepository : RepositoryAsync<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public ApplicationUserRepository(ApplicationDbContext db, UserManager<ApplicationUser> userManager) : base(db)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task UpdateAsync(ApplicationUser user)
        {
            var userFromDb = await _userManager.FindByIdAsync(user.Id);
            if (user != null)
            {
                userFromDb.FirstName = user.FirstName;
                userFromDb.LastName = user.LastName;
                userFromDb.PhoneNumber = user.PhoneNumber;
            }   
        }
    }
}
