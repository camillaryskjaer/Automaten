using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Logic
{
    class Customer
    {
        // gives the customer some cash
        public int cash = 1000;
        public Customer()
        {
            
        }
        // Method for the customer to purchase an item from the vending machine
        public int PurchaseItem(int money)
        {
            cash -= money;
            return cash;

        }
        
    }
}
