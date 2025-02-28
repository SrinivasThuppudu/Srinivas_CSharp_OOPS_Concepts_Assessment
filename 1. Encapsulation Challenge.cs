using System;

class BankAccount
{
    private double balance;
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        balance += amount;
    }
    public bool Withdraw(double amount)
    {
        if (amount > balance)
        {
            return false;
        }
        balance -= amount;
        return true;
    }
    public double GetBalance()
    {
        return balance;
    }
}