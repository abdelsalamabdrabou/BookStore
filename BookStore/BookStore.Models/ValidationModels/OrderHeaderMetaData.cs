using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ValidationModels
{
    internal class OrderHeaderMetaData
    {
        [Required, Phone, Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required, Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }
    }
}
