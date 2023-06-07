using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Welcome_Page
    {

         static List<Customer> customers = new List<Customer>();
         static Customer currentCustomer;

        public void WelcomePage()
        {
            Console.WriteLine("***********  Welcome to Zik_Global Bank  **************\n");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using the Bank App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }

        }
        static void Register()
        {
            Console.WriteLine("\nRegistration Form");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Customer newCustomer = new Customer(name, email, password);
            customers.Add(newCustomer);

            Console.WriteLine("\nRegistration successful. Please log in.");
        }
        static void Login()
        {
            Console.WriteLine("\nLogin");

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            currentCustomer = customers.Find(customer => customer.Email == email && customer.ValidatePassword(password));
            if (currentCustomer != null)
            {
                Console.WriteLine("\nLogin successful.");
                ShowCustomerMenu();
            }
            else
            {
                Console.WriteLine("\nInvalid email or password. Please try again.");
            }
            static void ShowCustomerMenu()
            {
                while (true)
                {
                    Console.WriteLine("\nPlease select an option:");
                    Console.WriteLine("1. Open Savings Account");
                    Console.WriteLine("2. Open Current Account");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Transfer");
                    Console.WriteLine("5. Logout");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            OpenSavingsAccount();
                            break;
                        case "2":
                            OpenCurrentAccount();
                            break;
                        case "3":
                            PerformDeposit();
                            break;
                        case "4":
                            PerformTransfer();
                            break;
                        case "5":
                            currentCustomer = null;
                            Console.WriteLine("Logout successful.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            static void OpenSavingsAccount()
            {
                SavingsAccount savingsAccount = new SavingsAccount();
                currentCustomer.AddAccount(savingsAccount);
                Console.WriteLine("Savings account opened successfully.");
            }
            static void OpenCurrentAccount()
            {
                CurrentAccount currentAccount = new CurrentAccount();
                currentCustomer.AddAccount(currentAccount);
                Console.WriteLine("Current account opened successfully.");
            }
            static void PerformDeposit()
            {
                Console.Write("\nEnter the account number: ");
                string accountNumber = Console.ReadLine();

                Console.Write("Enter the deposit amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                BankAccount account = currentCustomer.GetAccount(accountNumber);
                if (account != null)
                {
                    account.Deposit(amount);
                    Console.WriteLine("Deposit successful.");
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
            }
            static void PerformTransfer()
            {
                Console.Write("\nEnter the source account number: ");
                string sourceAccountNumber = Console.ReadLine();

                Console.Write("Enter the destination account number: ");
                string destinationAccountNumber = Console.ReadLine();

                Console.Write("Enter the transfer amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                BankAccount sourceAccount = currentCustomer.GetAccount(sourceAccountNumber);
                BankAccount destinationAccount = currentCustomer.GetAccount(destinationAccountNumber);

                if (sourceAccount != null && destinationAccount != null)
                {
                    bool transferSuccessful = sourceAccount.Transfer(amount, destinationAccount);
                    if (transferSuccessful)
                    {
                        Console.WriteLine("Transfer successful.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds for transfer.");
                    }
                }
                else
                {
                    Console.WriteLine("One or both accounts not found.");
                }
            }

        }
    }
}
