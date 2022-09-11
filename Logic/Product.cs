using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Logic
{
    public class Product
    {
        // Fields
        private string name;
        private int price;

        // Default constructor
        public Product()
        {
        }

        // Constructor that has name and price
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        // Properties
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
