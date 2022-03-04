using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public  class OrderConfirmationVM
    {
        public string OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public IEnumerable<OrderConfirmationItems> Items { get; set; }
        public double Total { get; set; }
        public string Address { get; set; }
    }
}
