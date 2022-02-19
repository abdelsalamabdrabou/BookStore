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
    }
}
