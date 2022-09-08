using System;
using Automaten.Machine; // Allows the program.cs to acces the machine assets
using Automaten.Machine.Products;
using System.Collections.Generic;
namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VendingMachine vend = new VendingMachine();
            vend.Slots = 9;
            Console.WriteLine("The vending machine has {0} slots",vend.Slots);
            Product idk = new Product();

            List<Product> list = new List<Product>();
            list.Add();
            Soda soda = new Soda("Pepsi","Faxe","Cola");
            Chips chips = new Chips("Taffel", "Kims", "Lays");
            foreach (string i in )
            {

            }
            

        }
    }
}
