using System;
using System.Collections.Generic;
using Automaten.Logic;

namespace Automaten.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of objects
            VendingMachine vm = new();
            Customer customer = new();
            Admin adm = new();
           
            string choice = "";
            int input = 0;
            int i = 0;
            bool isRunning = true;

            do // loop runs until isRunning is false
            {
                int money = 0;
                
                Console.ForegroundColor = ConsoleColor.Blue;
                switch (i)
                {                   
                    case 0:
                        Console.Write( // GUI Menu
                            "  _________________________________\n" +
                            " /         Vending Machine         \\ \n" +
                            " |_________________________________|\n" +
                            " |      1.| Purcase an item        |\n" +
                            " |      2.| Admin menu             |\n" +
                            " |      3.| Exit                   |\n" +
                            " |_________________________________|\n" +
                            "  Enter Your choice: "  
                            );
                        i = int.Parse(Console.ReadLine()); // User Input
                        break;

                    // Case 1 is for the customer to order an item
                    case 1: 
                        i = 0;
                        Console.Clear();
                        Console.WriteLine(vm.ShowItems()); // Writes the method showItems
                        bool correctMoney = false;
                        do // Loop runs until correctMoney is true
                        {

                            Console.Write("Enter money: ");
                            int moneyInput = int.Parse(Console.ReadLine());
                            
                            money += moneyInput;
                            if (money >= 20)
                            {
                                correctMoney = true;
                            }
                            else
                            {
                                Console.WriteLine("You have not inserted enough money");

                            }
                        } while (correctMoney == false);

                        Console.WriteLine("Enter Number of item: ");
                        input = int.Parse(Console.ReadLine());

                        // The user can cancel his order by typing n, and resume the order with y
                        Console.WriteLine("Do you want to make this purchase? y/n");

                        choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            // runs the different methods to remove the item that was purchases
                            if (money <= customer.cash)
                            {
                                if (input == 1)
                                {
                                    vm.GetSlot1();
                                }
                                else if (input == 2)
                                {
                                    vm.GetSlot2();
                                }
                                else if (input == 3)
                                {
                                    vm.GetSlot3();
                                }
                                else
                                {
                                }
                                // The vending machine says thank you for your order, and uses an method to give any change
                                Console.Clear();
                                Console.WriteLine("Thank you for your purchase, enjoy your beverage");
                                Console.WriteLine("Your change: " + vm.GiveChange(money) + "DKK");
                                customer.cash = customer.cash + vm.GiveChange(money);

                                Console.WriteLine("\nPress <Enter> to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            else { Console.Clear(); Console.WriteLine("You dont have enough money"); }
                        }
                        else if (choice.ToLower() == "n")
                        {
                            Console.Clear();
                        }
                        break;

                        // Admin menu
                    case 2:
                        i = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                                                Console.Write(
                            "  _________________________________\n" +
                            " /  Vending Machine | Admin Menu   \\ \n" +
                            " |_________________________________|\n" +
                            " |      1.| Restock                |\n" +
                            " |      2.| Change price          |\n" +
                            " |      3.| Withdraw money         |\n" +
                            " |      4.| Exit                   |\n" +
                            " |_________________________________|\n" +
                            "  Enter Your choice: "
                            );
                        int admInput = Int32.Parse(Console.ReadLine());
                        
                        if (admInput == 1) // Restock section
                        {
                            Console.Clear();
                            Console.WriteLine(vm.DisplayProductsAmount());
                            Console.WriteLine("What item do you want to restock? ");
                            int item = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many do you want to fill?");
                            int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine(vm.FillStock(amount, item));
                        }
                        else if (admInput == 2) // Change price section
                        {
                            Console.Clear();
                            Console.WriteLine(vm.ShowItems());
                            Console.WriteLine("What item do you want to change the price on? ");
                            int item = int.Parse(Console.ReadLine());
                            Console.WriteLine("What should the price on the item be? ");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine(vm.ChangePrice(item, price));
                        }
                        else if (admInput == 3) // withdraw money from vending machine section
                        {
                            Console.WriteLine(adm.WithdrawVendingCash());
                        }
                        else
                        {

                        }

                        break;
                    case 3:
                        isRunning = false;
                        Console.WriteLine("Goodbye, have a good day!");
                        Console.ReadLine();
                        break;
                    default:
                        i = 0;
                        break;
                }
            } while (isRunning == true) ;
        }
    }
}
