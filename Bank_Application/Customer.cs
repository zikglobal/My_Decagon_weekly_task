using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Customer
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }


        public Customer( string fullname, string email, string  password )
        {
            Fullname = fullname;
            Email = email;
            Password = password;
        } 
    }
}
