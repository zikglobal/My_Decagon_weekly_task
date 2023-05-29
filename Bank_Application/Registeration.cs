using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Registeration
    {

        static string Fullname = "";
        static string EmailAddress = "";
        static string Pass = "";


       public  void Register()

        {
            Console.WriteLine("\n Welcome to the registeration portal");


            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Fullname = name;

            Console.WriteLine("Enter your Email Address:");
            string email = Console.ReadLine() ;
            EmailAddress = email;


            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Pass = password;

            Customer record = new Customer( name, email, password);
            Program.allCustomers.Add( record );

            AddAccount();
        }


        public void AddAccount()
        {
            Console.WriteLine("What type of account do you want to open ?");
            Console.WriteLine("Press 1 for Savings\nPress 2 for Current");
            string acctype = Console.ReadLine();
            if (acctype == "1")
            {
                string AccountType = "Savings";
                decimal Balance = 0;
                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string AccNo = i.ToString();
                Account SavingsAcc = new Account(Fullname,AccNo,AccountType,Balance);
                Program.allAccounts.Add( SavingsAcc );
                Console.WriteLine("Your account was created sucessfull");
            }
            else if(acctype == "2")
            {
                string AccountType = "current";
                decimal Balance = 0;
                Random random = new Random();
                var i = random.Next(1000000000, 2099999999);
                string AccNo = i.ToString();
                Account CurrentAcc = new Account(Fullname, AccNo, AccountType, Balance);
                Program.allAccounts.Add(CurrentAcc);
                Console.WriteLine("Your account was created sucessfully");
            }
            else
            {
                Console.WriteLine("Wrong input! Hope ure not a robot ?\n Try again.");
                AddAccount();
            }
          
        }
    }
}
