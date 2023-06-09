using Bank_App.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class Menu : IMenu
    {
        private readonly IAccountService _accountService;
        private readonly ICreateAccountService _createAccountService;
        public Menu(IAccountService accountService, ICreateAccountService createAccountService)
        {
            _accountService = accountService;
            _createAccountService = createAccountService;
        }
        public void MainMenu()
        {

            Console.WriteLine("************ Welcome to Zik_Global Bank **********\n");

            Console.WriteLine("\nplease select an option:\n");


            Console.WriteLine("1. Create Account\n2 Check Balance\n3. Deposit\n4. Withdraw\n5. Transfer \n6. DisplayAllTables  \n7 Logout\n");
            Console.WriteLine("");

            string option = Console.ReadLine();
            if (option == "1")
            {
                _createAccountService.CreateAccount();
                MainMenu();

            }

            else if (option == "2")
            {
                _accountService.CheckBalance();
                MainMenu();
                //  CheckBalance();
                //  string AcctNumber = Console.ReadLine();
                //  Console.WriteLine($"Your account balance is: ");

            }
            else if (option == "3")
            {
                _accountService.Deposit();
                MainMenu();
                //  Deposit();

                //Console.WriteLine("Enter the amount to deposit");

            }
            else if (option == "4")
            {
                _accountService.Withdraw();
                MainMenu();
                //  Withdraw();
                //Console.WriteLine("To make a withdrawal, enter the amonut");


            }
            else if (option == "5")
            {
                _accountService.Transfer();
                MainMenu();
                //  DisplayTable.DisplayAllTables();

            }
           /* else if (option == "6")
            {
                _accountService.DisplayAllTables();
                MainMenu();

                //   WelcomePage();
                //  Console.WriteLine("Below is your account details");
            }*/
            else if (option == "7")
            {
                Console.WriteLine("Thank you for Banking with us");
                // Transfer();

            }
            else 
            {
               MainMenu();
            }


        }

    }
}
