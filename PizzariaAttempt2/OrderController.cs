using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class OrderController {

        public void AddPizzaToOrder(Pizza pizza) 
        {
            
            OrderManager orderManager = new OrderManager();
            Console.WriteLine("How many do you want?");
            int numberOfTimes = int.Parse(Console.ReadLine());
            orderManager.AddPizzaToOrder(pizza, numberOfTimes);
        }
        public double OrderedPizzas ()
        { 
            double totalPrice = 0;
            OrderManager orderManager = new OrderManager();
            foreach (var pizza in orderManager.PizzasAddedToOrder())
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
            OrderManager orderManager = new OrderManager();
            orderManager.clearOrderList();
        }
        public string customerName() 
        {
            OrderManager orderManager =new OrderManager();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string formattedName = char.ToUpper(name[0]) + name.Substring(1);
            return orderManager.customerName(formattedName);
        }

        
    }
}
