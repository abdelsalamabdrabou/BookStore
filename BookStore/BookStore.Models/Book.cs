using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public int PublicationYear { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public double DiscountRate { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public double OfferingPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Cart> Carts { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
