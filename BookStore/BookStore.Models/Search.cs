using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Search
    {
        [Required]
        public string Value { get; set; }
        public string ErrorMessage { get; set; }
    }
}
