using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPINet3.Models
{
    public class SimpleNorthwindDataSource
    {
        public List<Models.Employee> GetEmployees()
        {
            return new List<Models.Employee>()
            {
                new Employee(){  EmployeeID=1,FirstName="Mario" , LastName ="Rossi", City="Londra"},
                new Employee(){  EmployeeID=2, FirstName="Gino" , LastName ="Bianchi", City ="Londra"}
            };
        }
    }
}