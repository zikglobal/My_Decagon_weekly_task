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
        
        public void WelcomePage()
        {
            Console.WriteLine("Welcome to Zik_Global Bank");

            while (true)
            {
                Console.WriteLine("\nplease select an option:\n");
               
                Console.WriteLine("To Register press 1");
                Console.WriteLine("To Login press 2");
                Console.WriteLine("To Exit press 3");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var myreg = new Registeration();
                            myreg.Register(); 
                        break;
                    case "2":
                        Console.WriteLine("Login");
                        break;
                    case "3":
                        Console.WriteLine("Exit");
                    
                        Console.WriteLine("Thank you for using the Bank Application, goodbye");
                        return;
                    default:
                        Console.WriteLine("You entered an invalid option. please try again.");
                        break;


                }



        }    }
    }
}
