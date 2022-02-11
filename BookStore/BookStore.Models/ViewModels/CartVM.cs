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
        public string CartId { get; set; }
        public string BookId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        [Required, Range(1, 5, ErrorMessage = "The field {0} must be greater than {1} and less than {2}.")]
        public int Count { get; set; }
        public Book Book { get; set; }
        public ApplicationUser User { get; set; }
    }
}
