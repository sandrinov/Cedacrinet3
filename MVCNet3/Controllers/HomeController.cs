using MVCNet3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNet3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SimpleNorthwindDataSource ds = new SimpleNorthwindDataSource();

            return View(ds.GetEmployees());
        }
    }
}