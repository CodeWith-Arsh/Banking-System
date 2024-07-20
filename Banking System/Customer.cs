using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Customer
    {
        public string CustomerId { get; private set; }
        public string Name { get; private set; }

        public Customer(string customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public override string ToString()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}";
        }
    }


}
