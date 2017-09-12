using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;

namespace MVCNet3
{
    /// <summary>
    /// Summary description for MeteoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MeteoService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetPrevisione(String citta)
        {
            Thread.Sleep(5000);
            return "SUN!";
        }

        [WebMethod]
        public double GetTemperatura(String citta)
        {
            double d = 15.9F;
            return d;
        }
    }
}
