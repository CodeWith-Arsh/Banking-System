using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; protected set; }
        public Customer AccountHolder { get; private set; }

        public Account(string accountNumber, decimal initialBalance, Customer accountHolder)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            AccountHolder = accountHolder;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}, Balance: {Balance}, Account Holder: {AccountHolder.Name}";
        }
    }

}
