using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Invoice_info
{
    class Invoice
    {
        //fields
        private string id;
        private string name;
        private int price;
        private int quantity;

        //properties
        public string Id
        {
            get { return id; }
            set { id = "ID-" + value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price.ToString(); }
            set { price = Convert.ToInt16(value); }
        }
        public string Quantity
        {
            get { return quantity.ToString(); }
            set { quantity = Convert.ToInt16(value); }
        }
     
        public Invoice(string id, string name, string price, string quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string overallPriceCalculator()
        {
            return (price * quantity).ToString();
        }
    }
}
