using System;

namespace DelegateEx
{
    public delegate void BalanceHandler(double amount);
    public class Account
    {
        public int accountNumber;
        public string customerName;
        public double balance;

        public event BalanceHandler UnderBalance;
        public event BalanceHandler BalanceZero;

        public Account(int accNo, string name, double bal) 
        { 
            accountNumber = accNo;
            customerName = name;
            balance = bal;
        }
        public double Withdraw(double amount)
        {
            this.CheckBalance(amount);
            return balance - amount;
        }

        public double Deposit(double amount)
        {
            return balance + amount;
        }

        public void CheckBalance(double amount)
        {
            if (BalanceZero != null) 
            {
                BalanceZero(amount);
            }
            else if (UnderBalance != null)
            {
                UnderBalance(amount);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1, "Ravi", 0);
            acc.UnderBalance += (double amount) =>
            {
                if (acc.balance < amount)
                {
                    Console.WriteLine("Insufficient Amount");
                }
            };
            acc.BalanceZero += (double amount) =>
            {
                if (acc.balance == 0)
                {
                    Console.WriteLine("Zero Balance");
                }
            };
            acc.Withdraw(200000);
        }
    }
}
