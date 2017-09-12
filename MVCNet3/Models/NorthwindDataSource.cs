using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNet3.Models
{
    public class SimpleNorthwindDataSource : INorthwindDataSource
    {
        public List<MVCNet3.Models.Employee> GetEmployees()
        {
            return new List<MVCNet3.Models.Employee>()
            {
                new Employee(){  EmployeeID=1,FirstName="Mario" , LastName ="Rossi", City="Londra"},
                new Employee(){  EmployeeID=2, FirstName="Gino" , LastName ="Bianchi", City ="Londra"}
            };
        }
    }
}