﻿using System;
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
                new Employee(){  EmployeeID =1,FirstName="Mario" , LastName ="Rossi", City="Londra"},
                new Employee(){  EmployeeID=2, FirstName="Gino" , LastName ="Bianchi", City ="Londra"},
                new Employee(){  EmployeeID=3,FirstName="Giulia" , LastName ="Verdi", City="Roma"},
                new Employee(){  EmployeeID=4, FirstName="Ugo" , LastName ="Viola", City ="Milano"}
            };
        }

        internal List<Order> GetOrdersByEmployeeID(int employeeID)
        {
            List<Order> Orders = null;
            if (employeeID == 1)
            {
                Orders = new List<Order>(){
                         new Order() {
                             OrderID =1,
                             OrderNumber ="AAA123",
                             OrderDate = DateTime.Now.AddDays(-125) },
                         new Order() {
                             OrderID =2,
                             OrderNumber ="BCD65723",
                             OrderDate = DateTime.Now.AddDays(-23) },
                         new Order() {
                             OrderID =3,
                             OrderNumber ="DFR45825",
                             OrderDate = DateTime.Now.AddDays(-98) }
                     };
            }
            else
                Orders = new List<Order>();
            return Orders;
        }
    }
}