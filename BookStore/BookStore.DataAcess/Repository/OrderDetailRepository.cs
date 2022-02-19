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
    public class OrderDetailRepository : RepositoryAsync<OrderDetail>, IOrderDetailRepoistory
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
