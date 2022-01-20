using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class UserRoles
    {
        public string UserId { get; set; }
        public List<Checkbox> Roles { get; set; }
    }
}
