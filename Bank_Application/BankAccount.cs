using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    abstract class BankAccount
    {
        private static int nextAccountNumber = 1;

        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public BankAccount()
        {
            AccountNumber = GenerateAccountNumber();
        }
        private string GenerateAccountNumber()
        {
            string accountNumber = $"ACCT-{nextAccountNumber:D5}";
            nextAccountNumber++;
            return accountNumber;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract bool Transfer(decimal amount, BankAccount destinationAccount);

    }
}
