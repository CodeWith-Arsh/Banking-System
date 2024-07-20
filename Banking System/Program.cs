using Banking_System;
using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Console.Write("Enter Customer ID for the first customer: ");
        string customerId1 = Console.ReadLine();
        Console.Write("Enter Customer Name for the first customer: ");
        string customerName1 = Console.ReadLine();
        Customer customer1 = new Customer(customerId1, customerName1);
        bank.AddCustomer(customer1);

        Console.Write("Enter Customer ID for the second customer: ");
        string customerId2 = Console.ReadLine();
        Console.Write("Enter Customer Name for the second customer: ");
        string customerName2 = Console.ReadLine();
        Customer customer2 = new Customer(customerId2, customerName2);
        bank.AddCustomer(customer2);

        SavingsAccount savingsAccount1 = new SavingsAccount("S123", 1000m, customer1);
        SavingsAccount savingsAccount2 = new SavingsAccount("S124", 1500m, customer2);

        bank.AddAccount(savingsAccount1);
        bank.AddAccount(savingsAccount2);

        savingsAccount1.Deposit(200m);
        savingsAccount1.Withdraw(150m);

        savingsAccount2.Deposit(300m);
        savingsAccount2.Withdraw(600m);

        Console.WriteLine("\nAll Accounts:");
        bank.PrintAllAccounts();

        Console.WriteLine("\nAll Customers:");
        bank.PrintAllCustomers();
    }
}
