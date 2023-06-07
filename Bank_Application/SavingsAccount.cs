using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class SavingsAccount:BankAccount
    {
        public override bool Transfer(decimal amount, BankAccount destinationAccount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                destinationAccount.Deposit(amount);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
