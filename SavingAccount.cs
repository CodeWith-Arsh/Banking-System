using System;

public class Class1
{
	public class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber, decimal initialBalance, Customer accountHolder)
        : base(accountNumber, initialBalance, accountHolder) { }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new Exception("Insufficient balance.");
        }
    }
}

}
