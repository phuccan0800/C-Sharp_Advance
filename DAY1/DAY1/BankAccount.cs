using System;

namespace DAY1
{
    internal class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id { get { return id; } set { id = Id; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Problem2: Account {this.Id}, balance {this.Balance}";
        }
    }
}
