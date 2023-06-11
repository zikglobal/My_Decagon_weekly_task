using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_App.Core.Interface;
using BankApp.Data;

namespace Bank_App.Core.Implementation
{
    public class CreateAccountService : ICreateAccountService
    {
        
        public void CreateAccount()
        {

            Console.Clear();
            Console.WriteLine("Enter an account type: \n1. Current\n2.Savings");
            string AcctType = Console.ReadLine();

            if (AcctType == "1")
            {
               var Acct = "current";

                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string accountnumber = i.ToString();
                User user = new User();
                var account = new Account
                {
                    AccountBalance = 0,
                    AccountNumber = accountnumber,
                    AccountType = AccountType.Current,
                    FullName = user.FirstName + " " + user.LastName,
                };
                using (StreamWriter writer = new StreamWriter("AccountData.txt", true))
                {
                    writer.WriteLine($"|{account.AccountNumber}  |{account.AccountBalance}|{account.AccountType}");
                    // writer.WriteLine($"|    {user.}   |   {}   |    {}    |    {user.Email}");
                    Console.WriteLine("user added to file");
                }
                Console.WriteLine($"Your Current Account number is: {accountnumber}");
                Console.WriteLine($"Your current account balance is: {account.AccountBalance}");

            }
            else if (AcctType == "2")
            {
                Console.Clear();
               var Acct = "savings";

                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string accountnumber = i.ToString();
                User user2 = new User();
                var account = new Account
                {
                    AccountBalance = 0,
                    AccountNumber = accountnumber,
                    AccountType = AccountType.Savings,
                    FullName = user2.FirstName + " " + user2.LastName,
                };
                using (StreamWriter writer = new StreamWriter("AccountData.txt", true))
                {
                    writer.WriteLine($"|  {user2.FirstName}| {user2.LastName}|{account.AccountNumber}  |{account.AccountBalance}|{account.AccountType}");
                    // writer.WriteLine($"|    {user.}   |   {}   |    {}    |    {user.Email}");
                    Console.WriteLine("user added to file");
                }
                Console.WriteLine($"Your Saving Account number is: {accountnumber}");
                Console.WriteLine($"Your savings account balance is : {account.AccountBalance}");
            }
            else
            {
                CreateAccount();
            }
        }


    }
}
