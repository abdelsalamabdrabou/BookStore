using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class ProductVM
    {
        public Book Book { get; set; }
        public IEnumerable<Book> BooksBestSellers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Cart Cart { get; set; }
    }
}
