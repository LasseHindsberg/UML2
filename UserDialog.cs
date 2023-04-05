namespace UML2
{
    public class UserDialog
    {
        MenuCatalog _menuCatalog;
        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }
        #region Create
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
            while (true)
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

            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    pizzaItem.pizzaID = Int32.Parse(input);
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
        #endregion
        #region Menu
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Big Mama Pizzaria |");
            Console.WriteLine("|     PIZZAMENU     |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("--------------------");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
                Console.WriteLine("--------------------");
            }
            Console.Write("Enter Option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            {
                try
                {
                    int result = Int32.Parse(input);
                    return result;
                }

                catch (FormatException e)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Unable to parse '{input}' - Error Message: {e.Message}");
                    Console.WriteLine("Input has to be a number. \nPlease enter your choice again (1-6)");
                }
                return -1;
            }
        }
        #endregion
        #region Run Function
        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "1. Create new pizza",
                "2. Search for a pizza",
                "3. View Pizzas",
                "4. Update Pizza",
                "5. Delete Pizza",
                "6. Exit"
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
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
                        try
                        {

                            Console.WriteLine("Search for a pizza by entering id");
                            int pizzaID = int.Parse(Console.ReadLine());

                            _menuCatalog.Search(pizzaID);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No Pizza found.");
                        }
                        Console.Write("Hit any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        _menuCatalog.PrintMenu();
                        Console.WriteLine("Hit any key to continue...");
                        Console.ReadKey();
                        break;

                    case 4:
                        try
                        {
                            _menuCatalog.PrintMenu();

                            Console.WriteLine("Enter the ID of the pizza to update:");
                            int pizzaID = int.Parse(Console.ReadLine());

                            _menuCatalog.Update(pizzaID);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No Pizza Updated");
                        }
                        Console.Write("Hit any key to continue...");
                        Console.ReadKey();
                        break;

                    case 5:
                        try
                        {
                            _menuCatalog.PrintMenu();

                            Console.WriteLine("Enter the ID of the pizza to Delete:");
                            int pizzaID = int.Parse(Console.ReadLine());

                            _menuCatalog.Delete(pizzaID);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No Pizza Deleted.");
                        }
                        Console.Write("Hit any key to continue...");
                        Console.ReadKey();
                        break;


                    case 6:
                        proceed = false;
                        Console.WriteLine("Quitting Program...");
                        break;

                    default:
                        Console.WriteLine("Hit any key to continue");
                        Console.ReadKey();
                        break;


                }
            }
        }
        #endregion
    }
}
