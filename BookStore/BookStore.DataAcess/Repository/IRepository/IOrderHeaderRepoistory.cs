using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository.IRepository
{
    public interface IOrderHeaderRepoistory : IRepositoryAsync<OrderHeader>
    {
        Task UpdateAsync(OrderHeader orderHeader);
        Task UpdateAsync(Guid orderId, string orderStatus, string paymentStatus);
    }
}
