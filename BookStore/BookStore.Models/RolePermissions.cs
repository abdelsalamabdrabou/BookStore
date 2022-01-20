using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class RolePermissions
    {
        public string RoleId { get; set; }
        public List<string> Modules { get; set; }
        public List<string> Actions { get; set; }
        public List<Checkbox> Permissions { get; set; }
    }
}
