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
        Task UpdateAsync(Book book);
    }
}
