using Bank_App.Core;
using BankApp.Data.Dtos;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Bank_App.Core.Interface;
using System.ComponentModel.DataAnnotations;
using Bank_App.Core.Implementation;

namespace Bank_App.Core.implementation
{
    public class UserService : IUserService
    {
        private readonly IMenu _menu;

        public UserService (IMenu menu)
        {
            _menu = menu;
        }
       


        public User? user { get; set; }
        public void LogIn(string email, string password)
        {
           

            if (email == user.Email && password == user.PasswordHash)
            {
                Console.Clear();
                Console.WriteLine("You are Logged in Successfully");
                _menu.MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Login Details");
            }
        }

        public void Register(RegisterDto register)
        {
            user = new User

            
            {
                Email = register.EmailAddress,
                PasswordHash = register.Password,
                FirstName = register.FirstName,
                LastName = register.LastName,

            
            };
            using (StreamWriter writer = new StreamWriter("RegisterData.txt", true))
            {
                writer.WriteLine($"|  {user.FirstName}| {user.LastName}|{user.Email}  |{user.PasswordHash}|");
               // writer.WriteLine($"|    {user.}   |   {}   |    {}    |    {user.Email}");
                Console.WriteLine("user added to file");
            }
            // Console.WriteLine("\n Welcome to the registeration portal");

            /* var reg = new RegisterDto();
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
             reg.Password = password;*/


        }

        public void LogOut()
        {
            Environment.Exit(0);
        }


    }




}
