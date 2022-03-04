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
    public class OrderHeaderRepository : RepositoryAsync<OrderHeader>, IOrderHeaderRepoistory
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task UpdateAsync(OrderHeader orderHeader, string orderStatus, string paymentStatus)
        {
            var getOrderHeaderFromDb = await _db.OrderHeaders.FindAsync(orderHeader.OrderId);
            if (getOrderHeaderFromDb != null)
            {
                getOrderHeaderFromDb.OrderStatus = orderStatus;
                getOrderHeaderFromDb.PaymentStatus = paymentStatus;
                getOrderHeaderFromDb.PaymentDate = DateTime.Now;
            }
        }
    }
}
