using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    public class Order
    {
        public string OrderID { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public double totalPrice { get; set; }
        public int Month { get; set; }
    }
}
