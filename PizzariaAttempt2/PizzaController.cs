
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzariaAttempt2 {
    public class PizzaController {
        public PizzaController() { }

        public List<Pizza> DisplayMenu()
        {
            PizzaManager _pizzaManager = new PizzaManager();
            return _pizzaManager.DisplayMenu();
        }
        public static void InitialMenu()
        {
            PizzaManager.InitialMenu();
        }

        public Pizza CreatePizza()
        {
            
            double price = 0;
            Console.WriteLine("Please enter the name of the pizza");
            string name = Console.ReadLine();
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            bool IsValid = false;
            while (IsValid != true)
            {
                try
                {
                    Console.WriteLine("Please enter the price of the pizza");
                    string stringPrice = Console.ReadLine();


                    price = double.Parse(stringPrice);
                    IsValid = true;
                }
                catch
                {
                    Console.WriteLine("wrong format, please enter a number");
                }
            }
            Console.WriteLine("Please enter the name of the toppings");
            string toppings = Console.ReadLine();
            

            return PizzaManager.CreatePizza(formattedName,price,toppings); 

        }

        public Pizza SearchPizzaByNumber()
        {
            PizzaManager pizzaManager = new PizzaManager();
            int enteredNumber = 0;
            bool isValid = true;
            Pizza foundPizza = null;
            while (isValid)
            {

                
                string stringEnteredNumber = Console.ReadLine();
                try
                {
                    enteredNumber = Int32.Parse(stringEnteredNumber);
                    foundPizza = pizzaManager.SearchPizzaByNumber(enteredNumber);
                    if (foundPizza != null)
                    {
                        isValid = false;
                    }

                }
                catch
                {
                    Console.WriteLine("Please enter a number ");
                }
                
            }
            return foundPizza;
        }
        public Pizza SearchPizzaByName()
        {
            
            Pizza foundPizza = null;
            
            while (foundPizza == null)
            {
                Console.WriteLine("What is the name of the pizza?");
                string name = Console.ReadLine();
                foundPizza = PizzaManager.SearchPizzaByName(name);
                
            }
            return foundPizza;    
        }



        public void DeletePizza() 
        {
            PizzaManager pizzaManager = new PizzaManager();
            Console.WriteLine("What is the number of the pizza you want to delete?");
            
            pizzaManager.DeletePizza(SearchPizzaByNumber());
            
        }
    }
    

}
