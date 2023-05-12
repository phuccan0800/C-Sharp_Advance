using System;

namespace DAY1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Balance = 15;
            Console.WriteLine($"Problem1: Account {account.Id}, balance {account.Balance} ");
            account.Id = 1;
            account.Deposit(15);
            account.Withdraw(10);
            account.ToString();
        }
    }
}
