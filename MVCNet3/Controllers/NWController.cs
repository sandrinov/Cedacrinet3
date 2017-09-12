
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNet3.Controllers
{
    public class NWController : Controller
    {
        //private Models.EF.NorthwindEntities ctx;
        MVCNet3.Models.INorthwindDataSource _ds;
        public NWController(MVCNet3.Models.INorthwindDataSource ds)
        {
            //ctx = new Models.EF.NorthwindEntities();
            //ds = new MVCNet3.Models.SimpleNorthwindDataSource();
            _ds = ds;
        }
        // GET: NW/Employees
        public ActionResult Employees()
        {

            ///
            //var result = from e in ctx.Employees
            //             where e.City.StartsWith("Lon")
            //             orderby e.LastName
            //             select e;
            //return View(result.ToList());

            return View(_ds.GetEmployees());
        }

        public ActionResult EmployeeOrders(int id)
        {

            //var result = from e in ctx.Employees
            //             where e.EmployeeID == id
            //             select e.Orders;

            //var resultorder = ctx.Employees.
            //             Where(e => e.EmployeeID == id).
            //             Select(e => e.Orders);

            //var orders = resultorder.ToList();

            //return View(orders.FirstOrDefault());

            return View();
        }
    }
}