using Pizzaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class PizzaManager {

        public List<Pizza> DisplayMenu()
        {
            foreach (Pizza pizza in PizzaDataLayer.DisplayMenu())
            {
                Console.WriteLine("");
                Console.WriteLine(pizza);
            }

            return PizzaDataLayer.DisplayMenu();
        }
        public static void InitialMenu()
        {
            
                CreatePizza("Margherita",80, "Tomato & Cheese");
                CreatePizza("Vesuvio", 92, "Tomato, Cheese & Ham");
                CreatePizza("Capricciosa", 98, "Tomato, Cheese, Ham & Mushroom ");
        }
        public static Pizza CreatePizza (string name, double price, string toppings) 
        {
            Pizza pizza = new Pizza(name, toppings, price);
            PizzaDataLayer.CreatePizza(pizza);
            return pizza;
        }
        public Pizza SearchPizzaByNumber(int number)
        {
                int pizzanumber = number - 1;
                try
                {
                Pizza pizzaByIndex = PizzaDataLayer.DisplayMenu()[pizzanumber];
                return pizzaByIndex;
                }
                catch
                {
                    Console.WriteLine("No pizza was found, please try a different number");
                    return null;
                }
        }

        public static Pizza SearchPizzaByName(string name)
        {
            string formattedName = char.ToUpper(name[0]) + name.Substring(1);
            Pizza pizzaSearch = null;
            foreach (Pizza pizza in PizzaDataLayer.DisplayMenu())
            {
                if (pizza.Name == formattedName)
                {
                    pizzaSearch = pizza;
                }

            }
            if (pizzaSearch != null)
            {
                Console.WriteLine("your pizza is: \n" + pizzaSearch);
            }
            else
            {
                Console.WriteLine("Did not find pizza, please try again");
            }
            return pizzaSearch;

        }

    }
}
