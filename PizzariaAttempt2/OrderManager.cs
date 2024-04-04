using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public  class OrderManager {

        public void AddPizzaToOrder (Pizza pizza, int NumberOfTimes) 
        {
            for (int i = 0; i < NumberOfTimes; i++)
            {
                OrderDatalayer.AddPizzaToOrder(pizza);
            }
        }
        public Dictionary<Pizza,int> PizzasAddedToOrder () 
        {
            
            
            Dictionary <Pizza, int> uniquePizzaDictionary = new Dictionary <Pizza, int> ();
            
            foreach (Pizza orderedPizza in OrderDatalayer.ShowOrderedPizzas())
            {
                if (!uniquePizzaDictionary.ContainsKey(orderedPizza))
                {
                    uniquePizzaDictionary.Add (orderedPizza, 1);
                }
                else
                {
                    
                    uniquePizzaDictionary [orderedPizza] ++;
                }
                
                
            }
            

            return uniquePizzaDictionary;
        }

        


        //TODO: lav en udregning for prisen af pizzaer
        //TODO: tilføj kundens navn
    }
}
