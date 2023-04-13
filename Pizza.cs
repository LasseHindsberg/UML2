using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @Author: Lasse B. Hindsberg
 * 
 * Used Snippets from https://github.com/jpandersen61/UML2
 * 
*/

namespace UML2
{
    public class Pizza
    {
        public int pizzaID { get; set; }
        public string pizzaName { get; set; }
        public double pizzaPrice { get; set; }

        public override string ToString()
        {
            return $"ID: {pizzaID}, Name: {pizzaName}, Price: {pizzaPrice}";

        }
    }
}
