using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Machine.Products;

namespace Automaten.Machine
{
    internal class VendingMachine
    {
        private int slots;
        public int Slots 
        {
            get { return slots; }
            set { slots = value; }
        }
    }
}
