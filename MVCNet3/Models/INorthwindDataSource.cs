using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNet3.Models
{
    public interface INorthwindDataSource
    {
        List<MVCNet3.Models.Employee> GetEmployees();
    }
}
