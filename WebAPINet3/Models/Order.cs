using System;

namespace WebAPINet3.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string  OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}