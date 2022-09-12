using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Logic;

namespace Automaten.Logic
{
    public class VendingMachine
    {
        public int vendingBal = 0;
        // Makes 3 different lists for each soda type
        public List<Product> colaList = new();
        public List<Product> pepsiList = new();
        public List<Product> faxeList = new();
        // Makes an new soda product, and giving it value
        readonly Product cola = (new Product("Cola", 20));
        readonly Product pepsi = (new Product("Pepsi", 20));
        readonly Product faxe = (new Product("Faxe", 20));

        // 3 loops thats will 5 of each soda to their list
        public VendingMachine()
        {
            for (int i = 0; i < 5; i++)
            {
                colaList.Add(cola);
            }
            for (int i = 0; i < 5; i++)
            {
                pepsiList.Add(pepsi);
            }
            for (int i = 0; i < 5; i++)
            {
                faxeList.Add(faxe);
            }
        }
        // Method for showing the different items the customer can buy
        public string ShowItems()
        {
            string str;
            str = "1. " +colaList[0].Name + " " +colaList[0].Price + "DKK "+ colaList.Count + " tilbage\n" + "2. " + pepsiList[0].Name + " " + pepsiList[0].Price + "DKK " + pepsiList.Count + " tilbage\n" + "3. " + faxeList[0].Name + " " + faxeList[0].Price + "DKK " + faxeList.Count + " tilbage\n";

            return str;
        }
        // Method for giving the customer change if the inputtet money was over the product price
        public int GiveChange(int money)
        {
            
            //UPS DEN ER FARLIG, hvad hvis der ikke ligger nogle elementer i listen?
            int change = money - colaList[0].Price;
            
            return change;
        }
        
        
        
       //Du har 3 metoder som hedder næsten det samme - det er ikke godt, for her er der tale om redundant kode
        // Du kunne gøre det samme i kun een metode
        
        // Method for removing an item from colaList, as long as its over 0
        public void GetSlot1()
        {
            if (colaList.Count > 0)
            {
                colaList.RemoveAt(0);
                vendingBal += colaList[0].Price;
            }
        }
        // Method for removing an item from pepsiList, as long as its over 0
        public void GetSlot2()
        {
            if (pepsiList.Count > 0)
            {
                pepsiList.RemoveAt(0);
                vendingBal += pepsiList[0].Price;

            }
        }
        // Method for removing an item from faxeList, as long as its over 0
        public void GetSlot3()
        {
            if (faxeList.Count > 0)
            {
                faxeList.RemoveAt(0);
                vendingBal += faxeList[0].Price;
            }
        }
        // Method for displaying the Products amount to the admin 
        public string DisplayProductsAmount()
        {
            string str;
            str = "1. " + colaList[0].Name + " " + colaList.Count + " tilbage\n" + "2. " + pepsiList[0].Name + " " + pepsiList.Count + " tilbage\n" + "3. " + faxeList[0].Name + " " + faxeList.Count + " tilbage\n";

            return str;
        }
        // Method allowing the admin to select what list of items he wants to restock and how many items
        public string FillStock(int amount, int item)
        {
            if (item == 1)
            {
                for (int i = 0; i < amount; i++)
                {
                    colaList.Add(cola);
                }
                return "You have restocked the machine with "+ amount + " cola's there is now " + colaList.Count + " cola's in stock";
            }
            else if (item == 2)
            {
                for (int i = 0; i < amount; i++)
                {
                    pepsiList.Add(pepsi);
                }
                return "You have restocked the machine with " + amount + " pepsi's there is now " + pepsiList.Count + " pepsi's in stock";
            }
            else if (item == 3)
            {
                for (int i = 0; i < amount; i++)
                {
                    faxeList.Add(faxe);
                }
                return "You have restocked the machine with " + amount + " faxe's there is now " + faxeList.Count + " faxe's in stock";
            }
            return "";
        }
        //Method for admin to change the price
        public string ChangePrice(int item, int price)
        {
            if (item == 1)
            {
                colaList[0].Price = price; // Gives the price value a new value
                return "price of cola has been succesfully changed to " + colaList[0].Price; // Tells the admin that the price has been changed

            }
            else if (item == 2)
            {
                pepsiList[0].Price = price;
                return "price of pepsi has been succesfully changed to " + pepsiList[0].Price;

            }
            else if (item == 3)
            {
                faxeList[0].Price = price;
                return "price of faxe has been succesfully changed to " + faxeList[0].Price;
            }
            return "";

        }
    }
}
