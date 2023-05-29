using System.Transactions;
using System;
namespace Bank_Application
{
    internal class Program
    
    {
        public static List<Customer> allCustomers = new List<Customer>();

        public static List<Account> allAccounts = new List<Account>();
       
        static void Main(string[] args)
        {
            Welcome_Page welcome_Page = new Welcome_Page();
            welcome_Page.WelcomePage();

            Registeration registeration = new Registeration();
            registeration.Register();


        }
    }
}