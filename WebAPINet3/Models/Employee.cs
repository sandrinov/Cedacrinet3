using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINet3.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }
    }
}