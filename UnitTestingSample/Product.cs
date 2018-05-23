using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string productDescription { get; set; }

        public Product(int qty)
        {
            quantity = qty;
        }
    }
}
