
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCNet3.Controllers
{
    public class NWController : Controller
    {
        //private Models.EF.NorthwindEntities ctx;
        //MVCNet3.Models.INorthwindDataSource _ds;
        private HttpClient client = new HttpClient();
        public NWController(MVCNet3.Models.INorthwindDataSource ds)
        {
            //ctx = new Models.EF.NorthwindEntities();
            //ds = new MVCNet3.Models.SimpleNorthwindDataSource();
            //_ds = ds;
            client.BaseAddress = new Uri("http://localhost:2625/");
        }
        /// GET: NW/Employees
        public async Task<ActionResult> Employees()
        {
            var api_url = "api/employees";
            HttpResponseMessage egsResponse = await client.GetAsync(api_url);
            if (egsResponse.IsSuccessStatusCode)
            {
                string content = await egsResponse.Content.ReadAsStringAsync();
                var lstEmployees = 
                    JsonConvert.DeserializeObject<IEnumerable<WebAPINet3.Models.Employee>>(content);
                return View(lstEmployees);
            }
            else
            {
                return Content("An error occurred.");
            }
            
            ///
            //var result = from e in ctx.Employees
            //             where e.City.StartsWith("Lon")
            //             orderby e.LastName
            //             select e;
            //return View(result.ToList());

            //return View(_ds.GetEmployees());



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