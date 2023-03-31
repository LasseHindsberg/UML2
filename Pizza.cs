using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
