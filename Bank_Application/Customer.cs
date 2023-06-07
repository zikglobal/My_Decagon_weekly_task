using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
     class Customer
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        

        private List<BankAccount> accounts = new List<BankAccount>();

        public Customer(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public bool ValidatePassword(string password)
        {
            return Password == password;
        }

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public BankAccount GetAccount(string accountNumber)
        {
            return accounts.Find(a => a.AccountNumber == accountNumber);
        }
    }
}
