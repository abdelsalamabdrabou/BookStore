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
        Task DisposeAsync();
        Task SaveAsync();
    }
}
