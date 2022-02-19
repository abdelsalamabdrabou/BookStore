using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IBookRepoistory Book { get; }
        ICartRepoistory Cart { get; }
        IOrderHeaderRepoistory OrderHeader { get; }
        IOrderDetailRepoistory OrderDetail { get; }
        Task DisposeAsync();
        Task SaveAsync();
    }
}
