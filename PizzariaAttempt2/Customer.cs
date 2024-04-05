using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class Customer {
        public string Name { get; private set; }
        

        public string CustomerName(string name) 
        {
            Name = name;
            return name;
        }

     

    }
}
