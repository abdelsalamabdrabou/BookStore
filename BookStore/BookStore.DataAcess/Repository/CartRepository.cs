using BookStore.Data;
using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using BookStore.Utility.ConstantsStringSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository
{
    public class CartRepository : RepositoryAsync<Cart>, ICartRepoistory
    {
        private readonly ApplicationDbContext _db;
        public CartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task UpdateAsync(Cart cart)
        {
            var getCartFromDb = await _db.Carts.FindAsync(cart.CartId);
            if (getCartFromDb != null)
            {
                getCartFromDb.UpdatedDate = DateTime.Now;
                getCartFromDb.Count = cart.Count;
            }
        }
    }
}
