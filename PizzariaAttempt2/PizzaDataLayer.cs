
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzariaAttempt2 {
    public class PizzaDataLayer {

        private static List<Pizza> _menu = new List<Pizza>();

        public static Pizza CreatePizza(string name, double price, string toppings)
        {
            Pizza pizza = new Pizza(name, toppings, price);
            _menu.Add(pizza);
            return pizza;
        }
        


        public static List<Pizza> DisplayMenu()
        {
            return _menu;
        }
        public static void DeletePizza(int number)
        {
            
            _menu.Remove(_menu[number]);
        }



    }
}
