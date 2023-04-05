using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void Update(int pizzaID)
        {
            Pizza pizzaToUpdate = _pizzas.Find(p => p.pizzaID == pizzaID);

            
            if (pizzaToUpdate != null)
            {
                Console.WriteLine("Enter the new name for the pizza:");
                string newPizzaName = Console.ReadLine();


                Console.WriteLine("Enter the new price for the pizza:");
                double newPizzaPrice = double.Parse(Console.ReadLine());

                pizzaToUpdate.pizzaName = newPizzaName;
                pizzaToUpdate.pizzaPrice = newPizzaPrice;

                Console.WriteLine("Pizza updated successfully.");
            }
            else
            {
                Console.WriteLine("Pizza not found.");
            }
        }


        public void Delete(int pizzaID)
        {
            Pizza pizzaToRemove= _pizzas.Find(p => p.pizzaID ==pizzaID);

            if (pizzaToRemove != null )
            {
                _pizzas.Remove(pizzaToRemove);
                Console.WriteLine("Pizza Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Pizza not found");
            }
        }

        public void PrintMenu()
        {
            foreach(Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }
        }
        public void Search(int pizzaID)
        {
            Pizza pizzaToFind = _pizzas.Find(p => p.pizzaID == pizzaID);

            Console.WriteLine(pizzaToFind);
        }

    }
}
