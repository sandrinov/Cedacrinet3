using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPINet3.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class EmployeesController : ApiController
    {
        private Models.SimpleNorthwindDataSource ds;
        public EmployeesController()
        {
            ds = new Models.SimpleNorthwindDataSource();
        }

        [Route("api/employees")]
        public IHttpActionResult Get()
        {
            
            return Ok(ds.GetEmployees());
        }
        [Route("api/orders")]
        public IHttpActionResult Get(int employeeID)
        {
            return Ok(ds.GetOrdersByEmployeeID(employeeID));
        }
    }
}
