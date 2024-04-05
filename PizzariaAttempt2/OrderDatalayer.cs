
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class OrderDatalayer {

        private static List<Pizza> _orderedPizzas = new List<Pizza> ();

        public static void AddPizzaToOrder (Pizza pizza)
        {
            _orderedPizzas.Add (pizza);
        }

        public static List<Pizza> ShowOrderedPizzas ()
        {
            return _orderedPizzas;
        }
        public void ClearOrderList ()
        {
            _orderedPizzas.Clear ();
        }

        
    }
}
