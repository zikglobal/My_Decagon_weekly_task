using Bank_App.Core.Interface;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class AccountService : IAccountService
    {
        public void CheckBalance()
        {
            Console.Clear();
            string AcctNumber = "";

            Console.WriteLine($"Please Enter your Account Number");
            AcctNumber = Console.ReadLine();

          /*  foreach (Account account in CreateAccountService.)
            {
                if (account.AccountNumber == AcctNumber)
                {
                    Console.WriteLine($"Your balance for account number {AcctNumber} is {account.AccountBalance}");
                }
            }*/
        }
        public void Deposit()
        {
            Console.Clear();
            string AcctNumber = "";
            Console.WriteLine("Please Enter Your Account Number");
            AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount to deposit");
            decimal deposit = Decimal.Parse(Console.ReadLine());

           /* foreach (Account account in CreateAccountService.allAccounts)
            {
                if (AcctNumber == account.AccountNumber)
                {
                    deposit += account.AccountBalance;
                    Console.WriteLine($"Your account balance for {AcctNumber} is {deposit}");
                }
                else
                {
                    Deposit();
                }

            }*/
        }
        public void Withdraw()
        {
            Console.Clear ();
            Console.WriteLine("Please Enter your account number");
            var AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Withdraw");
            decimal withdraw = Decimal.Parse(Console.ReadLine());

          /*  foreach (Account account in CreateAccountService.allAccounts)
            {
                if (account.AccountNumber == AcctNumber)
                {
                    account.AccountBalance -= withdraw;
                    Console.WriteLine($"Your account balance for {AcctNumber} is {withdraw}");
                }
                else
                {
                    Withdraw();
                }
            }*/
        }
        public void Transfer()
        {
            Console.Clear();

            Console.WriteLine("Please Enter your account number");
            var sourceAccount = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Transfer");

            var amountTransfer = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter beneficiary account number");
           var transferAccount = Console.ReadLine();

          /*  foreach (Account account in CreateAccountService.allAccounts)
            {
                if (sourceAccount != null && transferAccount != null && amountTransfer >1000)
                {
                    
                   // sourceAccount. += amountTransfer;

                    Console.WriteLine("Transfer Successfull");
                    Console.WriteLine($" Your current account balance for {amountTransfer}is: {amountTransfer}");
                }
                else
                {
                    Transfer();

                }
            }*/
        }
      /*  public void DisplayAllTables()
        {
            Console.Clear();
           
            string allprints = "";
            foreach (Account account  in CreateAccountService.allAccounts)
            {
                allprints += $"|     {account.FullName,-15}|   {account.AccountNumber,-15}|     {account.AccountType,-15}|      {account.AccountBalance,-16}|\n";
            }
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine("|     FULLNAME       |  ACCOUNT NUMBER  |   ACCOUNT TYPE     |   ACCOUNT BALANCE    |");
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine(allprints);
            Console.WriteLine("------------------------------------------------------------------------------------");
        }*/

    }

}

