using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
  

    public class Bank
    {
        private List<Account> accounts;
        private List<Customer> customers;

        public Bank()
        {
            accounts = new List<Account>();
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void PrintAllAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }

        public void PrintAllCustomers()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }

}
