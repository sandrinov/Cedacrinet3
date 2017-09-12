using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNet3.Models
{
    public class EFNorthwindDataSource : INorthwindDataSource
    {
        private Models.EF.NorthwindEntities ctx;
        public EFNorthwindDataSource()
        {
            ctx = new EF.NorthwindEntities();
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> dtoList = new List<Employee>();
            EmployeeFactory factory = new EmployeeFactory();

            var result = from e in ctx.Employees
                         where e.City.StartsWith("Lon")
                         orderby e.LastName
                         select e;
           
            foreach (var item in result.ToList())
            {
                Models.EF.Employee entity = item as Models.EF.Employee;
                dtoList.Add(factory.GetDTO(entity));
            }

            return dtoList;
        }
    }
}