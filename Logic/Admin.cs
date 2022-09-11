using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Logic
{
    class Admin : VendingMachine
    {
        public int bal;
        
        public Admin()
        {
           
        }
        // Method for the admin the withdraw the cash inside the vending machine
        public string WithdrawVendingCash()
        {
            bal += vendingBal;
            vendingBal = 0;
            return "You have withdrawen the money from the vending machine, you now have: " + bal + " DKK";
        }
    }
}
