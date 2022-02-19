using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid OrderId { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
