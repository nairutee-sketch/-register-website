using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_in_C_
{
    internal class Program
 {
class bankaccount
        {
            private double balance;
            public double Balance
            {
                get { return balance; }
            }

            public void deposit (double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine("amount deposit successfully");
                }
                else
                {
                    Console.WriteLine("invalid amount");
                }
            }
            public void withdraw(double amount)
            {
                if ( amount > 0 && amount <= balance )
                { 
                    balance -= amount;

                }
                else
                {
                    Console.WriteLine("invalid amount");
                }
            }

        }
        static void Main(string[] args)
        {
               bankaccount ac = new bankaccount();
            ac.deposit(1100);
            ac.withdraw(500);
            Console.WriteLine("current balance" + ac.Balance);
        }
    }
}
