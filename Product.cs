using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15555
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // This method controls how the product appears in the list
        public override string ToString()
        {
            return $"{Name} (SKU: {SKU}) - Qty: {Quantity} - Price: ${Price}";
        }
    }

}
