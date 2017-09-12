using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNet3.Models
{
    public class EmployeeFactory
    {
        public MVCNet3.Models.Employee GetDTO(MVCNet3.Models.EF.Employee entity)
        {
            MVCNet3.Models.Employee dto = new MVCNet3.Models.Employee();
            dto.EmployeeID = entity.EmployeeID;
            dto.FirstName = entity.FirstName;
            dto.LastName = entity.LastName;
            dto.City = entity.City;

            return dto;
        }
    }
}