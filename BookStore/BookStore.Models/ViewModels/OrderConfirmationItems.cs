using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class OrderConfirmationItems
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
