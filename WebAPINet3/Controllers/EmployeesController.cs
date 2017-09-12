using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPINet3.Controllers
{
    public class EmployeesController : ApiController
    {
        [Route("api/employees")]
        public IHttpActionResult Get()
        {
            Models.SimpleNorthwindDataSource ds = new Models.SimpleNorthwindDataSource();
            return Ok(ds.GetEmployees());
        }
    }
}
