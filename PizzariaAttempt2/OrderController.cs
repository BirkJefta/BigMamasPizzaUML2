﻿using System;
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
        public void OrderedPizzas ()
        { 
            OrderManager orderManager = new OrderManager();
            foreach (var pizza in orderManager.PizzasAddedToOrder())
            {
                Console.WriteLine("");
                Console.WriteLine($" amount :{pizza.Value}, Pizza :{pizza.Key.Name} Price: {pizza.Key.Price}");
            }

        }

    }
}
