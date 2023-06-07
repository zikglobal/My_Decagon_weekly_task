using Bank_App.Core.Interface;
using BankApp.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class UserInterface 
    {
        private readonly IUserService _userService;

        public UserInterface(IUserService userService)
        {
            _userService = userService;
        }

        public void Run ()
        {
            Console.WriteLine("Enter 1 to Register");
            Console.WriteLine("Enter 2 to Login");
            Console.WriteLine("Enter 3 to Logout");

            var userInput = Console.ReadLine();
            Console.Clear();
            if (userInput == null)
            {
                Console.WriteLine("Please enter a number");
            }


            if (userInput == "1")
            {

                var reg = new RegisterDto();
                Console.WriteLine("Enter your First Name:");
                string firstname = Console.ReadLine();
                reg.FirstName = firstname;

                Console.WriteLine("Enter your Last Name:");
                string lastname = Console.ReadLine();
                reg.LastName = lastname;

                Console.WriteLine("Enter your Email Address:");
                string email = Console.ReadLine();
                reg.EmailAddress = email;


                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();
                reg.Password = password;
                _userService.Register(reg);
                Console.Clear();
                Console.WriteLine("Registration Successfull");
                Run();

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Please enter your email");
                var email = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                var password = Console.ReadLine();
                _userService.LogIn(email, password);
               
            }

            else if(userInput == "3")
            {
                _userService.LogOut();
            }
            else
            {
                Run();
            }
        }
        

        
        
    }
}
