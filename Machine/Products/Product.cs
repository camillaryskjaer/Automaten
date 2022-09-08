using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Machine.Products
{
    class Product
    {
        // Fields
        private string soda;
        private string chocolate;
        private string chips;

        // Properties
        public string Chips
        {
            get { return chips; }
            set { chips = value; }
        }
        public string Chocolate
        {
            get { return chocolate; }
            set { chocolate = value; }
        }
        public string Soda
        {
            get { return soda; }
            set { soda = value; }
        }
    }
}
