﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Creating Pizza      |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            pizzaItem.pizzaName = Console.ReadLine();

            string input = "";

            Console.Write("Enter Price: ");
            while(true)
            {
                try
                {
                    input = Console.ReadLine();
                    pizzaItem.pizzaPrice = Int32.Parse(input);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to parse '{input}' - Error Message: {e.Message}");
                    Console.WriteLine("input has to be a number.\nplease write price again in numbers");
                }
            }
            input = "";
            Console.WriteLine("Enter Pizza ID: ");

            while(true)
            {
                try
                {
                    input = Console.ReadLine();
                    pizzaItem.pizzaID =Int32.Parse(input);
                    break;
                }
                catch (FormatException e) 
                {
                    Console.WriteLine($"Unable to parse '{input}' - Error Message: {e.Message}");
                    Console.WriteLine("Input has to be a number.\nPlease write ID as a number.");
                    
                }
            }

            return pizzaItem;
        }
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Big Mama Pizzaria |");
            Console.WriteLine("|     PIZZAMENU     |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }
            Console.Write("Enter Option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            {

                try
                {
                    int result = Int32.Parse(input);
                    return result;
                }

                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{input}' - please enter as a number");
                }
                return -1;
            }
            
        }
        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Create new pizza",
                "2. Print menu",
                "3. Some choice"
            };

            while(proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting Program...");
                        break;

                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No Pizza Created");
                        }
                        Console.Write("Hit any key to continue...");
                        Console.ReadKey();
                        break;

                    case 2:
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Hit any key to continue...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine($"You've selected: {mainMenulist[MenuChoice]}");
                        Console.Write($"Hit any key to continue");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Hit any key to continue");
                        Console.ReadKey();
                        break;




                }
            }
        }
    }
}
