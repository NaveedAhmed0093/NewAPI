using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CRM.Model
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public long ZipCode { get; set; }
    }
}
