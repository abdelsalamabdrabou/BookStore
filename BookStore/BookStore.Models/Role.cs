using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Role
    {
        [Required, StringLength(256), Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}
