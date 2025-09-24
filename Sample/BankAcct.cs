using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class BankAcct
    {
        private object acctLock = new object();
        double balance {  get; set; }
        string Name { get; set;}
        public BankAcct (double bal)
        {
            balance = bal;  
        }
        public double Withdraw (double amt)
        {
            if((balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${balance} in Account");
                return balance;
            }
            lock (acctLock)
            {
                if(balance >= amt)
                {
                    Console.WriteLine ("removed {0} and {1} left in account",amt,(balance-amt));
                    balance -= amt;
                } 
                return balance;
            }
        }
        public void IssueWithdraw()
        {
            Withdraw(1);
            
        }
    }
}
