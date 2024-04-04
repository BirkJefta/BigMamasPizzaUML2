using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAttempt2 {
    public class Customer {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }

        public void CustomerName(string name) 
        {
            Name = name;
        }

        public void DetailsForMembership(string name, string address, string email)
        {
            Name += name;
            Address = address;
            Email = email;
        }

    }
}
