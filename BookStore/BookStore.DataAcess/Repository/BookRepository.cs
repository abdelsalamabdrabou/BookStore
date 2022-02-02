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
    public class BookRepository : RepositoryAsync<Book>, IBookRepoistory
    {
        private readonly ApplicationDbContext _db;
        public BookRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task UpdateAsync(Book book)
        {
            var getBookFromDb = await _db.Books.FindAsync(book.BookId);
            if (getBookFromDb != null)
            {
                getBookFromDb.Author = book.Author;
                getBookFromDb.Title = book.Title;
                getBookFromDb.ISBN = book.ISBN;
                getBookFromDb.Publisher = book.Publisher;
                getBookFromDb.PublicationYear = book.PublicationYear;
                getBookFromDb.Edition = book.Edition;
                getBookFromDb.CategoryId = book.CategoryId;
                getBookFromDb.Price = book.Price;
                getBookFromDb.ImageUrl = book.ImageUrl;
                getBookFromDb.Description = book.Description;
                getBookFromDb.DiscountRate = book.DiscountRate;
                getBookFromDb.Status = book.Status;
                getBookFromDb.Quantity = book.Status == Status.InStock.ToString().ToLower() ? book.Quantity : 0;
            }
        }
    }
}
