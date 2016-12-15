using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        public List<Product> shoppingCart = new List<Product>();
    }
}
