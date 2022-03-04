using BookStore.Models.ValidationModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    [ModelMetadataType(typeof(OrderHeaderMetaData))]
    public class OrderHeader
    {
        public Guid OrderId { get; set; }
        public string ProcessedBy { get; set; }
        public double TotalOrder { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string BillingAddress { get; set; }
        public DateTime ShippingDate { get; set; }
        public string TrackingNumber { get; set; }
        public string TransactionId { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
