using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class CartVM
    {
        public Guid BookId { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
    }
}
