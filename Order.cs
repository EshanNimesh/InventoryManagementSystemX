using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15555
{
    class Order
    {

        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string ResidentialAddress { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order() { }

        public Order(string CustomerID, string CustomerName, string PhoneNumber, string ResidentialAddress, string ProductName, int Quantity, int Price)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.PhoneNumber = PhoneNumber;
            this.ResidentialAddress = ResidentialAddress;
            this.ProductName = ProductName;
            this.Quantity = Quantity;
            this.Price = Price;
        }
    }
}
