
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class OrderDatalayer {

        private static List<Pizza> orderedPizzas = new List<Pizza> ();

        public static void AddPizzaToOrder (Pizza pizza)
        {
            orderedPizzas.Add (pizza);
        }

        public static List<Pizza> ShowOrderedPizzas ()
        {
            return orderedPizzas;
        }

        
    }
}
