using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Pizza {
        public string Name { get;  private set; }
        public string Toppings { get;  private set; }
       
        public double Price { get;  private set; }

        

        public Pizza(string name, string toppings, double price) 
        {
            Name = name;
            Toppings = toppings;
            Price = price;
            
        }

        public override string ToString()
        {
            
            return ( $" {Name} {Price},- kr \n" +
                $"ingredients: {Toppings}");
        }
    }
}
