using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository.IRepository
{
    public interface IBookRepoistory : IRepositoryAsync<Book>
    {
        Task<Book> GetByIdAsync(Guid id, string isbn);
        Task UpdateAsync(Book book);
    }
}
