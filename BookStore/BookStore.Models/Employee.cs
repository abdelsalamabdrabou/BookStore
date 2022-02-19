using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public double Salary { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
