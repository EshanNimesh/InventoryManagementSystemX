using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15555
{
    class Item
    {

        public string ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }


        public Item(string ID, string name, string description, int quantity, int price)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
