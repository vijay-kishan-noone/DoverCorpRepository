using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BankAccount
    {
        private string cname;
        private int accountBalance;
        public BankAccount(string cname)
        {
            this.cname = cname;
            if (DateTime.Now.DayOfWeek.ToString().ToLower() == "friday")
                accountBalance = 500;
            else
                accountBalance = 0; 
        }
        public void Deposit(int amount)
        {
            if (DateTime.Now.DayOfWeek.ToString().ToLower() == "sunday" || DateTime.Now.Hour < 9 || DateTime.Now.Hour > 17)
            {
                Console.WriteLine($"Dear {cname}, You cannot withdraw on non working hours or on Sunday " + DateTime.Now);
                return;
            }
            if (amount > 50000)
            {
                Console.WriteLine($"Dear {cname}, You cannot deposit morethan 50k " + DateTime.Now);
                return;
            }
            else
            {
                accountBalance += amount;
                Console.WriteLine($"Dear {cname}, Amount Deposited, and your total balance is {accountBalance} {DateTime.Now}");
            }
        }
        public void WithDraw(int amount)
        {
            if (DateTime.Now.DayOfWeek.ToString().ToLower() == "sunday" || DateTime.Now.Hour < 9 || DateTime.Now.Hour > 17)
            {
                Console.WriteLine($"Dear {cname}, You cannot withdraw on non working hours or on Sunday " + DateTime.Now);
                return;
            }
            if (accountBalance == 0)
            {
                Console.WriteLine($"Dear {cname}, You cannot withdraw since balance is zero " + DateTime.Now);
                return;
            }
            if(accountBalance< amount)
                Console.WriteLine($"Dear {cname}, You cannot withdraw more than your account balance " +DateTime.Now);
            else
            {
                accountBalance -= amount;
                Console.WriteLine($"Dear {cname}, Your total balance is {accountBalance} {DateTime.Now}");
            }
        }
    }
    class Program26
    {
        static void Main(string[] args)
        {
            BankAccount me = new BankAccount("Vijay");
            me.Deposit(1000);
            me.WithDraw(5000);
            BankAccount c = new BankAccount("Kiran");
            c.Deposit(500);
            c.WithDraw(500);
        }
    }
}
