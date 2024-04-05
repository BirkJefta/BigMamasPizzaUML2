using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class OrderController {
        OrderManager _orderManager;

        public OrderController() 
        { 
            _orderManager = new OrderManager();
        }

        public void AddPizzaToOrder(Pizza pizza) 
        {
            bool ValidIndput = false;
            
            Console.WriteLine("How many do you want?");
            while (ValidIndput == false)
            {
                try
                {
                    int numberOfTimes = int.Parse(Console.ReadLine());
                    _orderManager.AddPizzaToOrder(pizza, numberOfTimes);
                    ValidIndput = true;
                }
                catch 
                {
                    Console.WriteLine("Please enter a number");
                }
            }
        }
        public double OrderedPizzas ()
        { 
            double totalPrice = 0;
            
            foreach (var pizza in _orderManager.PizzasAddedToOrder())
            {
                double price = pizza.Key.Price * pizza.Value; 
                Console.WriteLine("");
                Console.WriteLine($"Amount :{pizza.Value}, Pizza :{pizza.Key.Name} " +
                    $"  Price: {price},-");
                totalPrice += price;
            }
            Console.WriteLine($"Your total is: {totalPrice}");
            return totalPrice;
        }
        public void clearOrderList ()
        {
            
            _orderManager.clearOrderList();
        }
        public string customerName() 
        {
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string formattedName = char.ToUpper(name[0]) + name.Substring(1);
            return _orderManager.customerName(formattedName);
        }

        
    }
}
