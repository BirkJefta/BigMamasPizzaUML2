using Pizzaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class PizzaDataLayer {

        private static List<Pizza> _menu = new List<Pizza>();

        public static Pizza CreatePizza(Pizza pizza)
        {
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
