using Banking_System;
using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Customer customer1 = new Customer("C001", "Alice");
        Customer customer2 = new Customer("C002", "Bob");

        bank.AddCustomer(customer1);
        bank.AddCustomer(customer2);

        SavingsAccount savingsAccount1 = new SavingsAccount("S123", 1000m, customer1);
        SavingsAccount savingsAccount2 = new SavingsAccount("S124", 1500m, customer2);

        bank.AddAccount(savingsAccount1);
        bank.AddAccount(savingsAccount2);

        savingsAccount1.Deposit(200m);
        savingsAccount1.Withdraw(150m);

        savingsAccount2.Deposit(300m);
        savingsAccount2.Withdraw(600m);

        Console.WriteLine("All Accounts:");
        bank.PrintAllAccounts();

        Console.WriteLine("\nAll Customers:");
        bank.PrintAllCustomers();
    }
}
