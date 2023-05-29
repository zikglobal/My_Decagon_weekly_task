using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
   
    internal class Account

    {
        string Fullname {  get; set; }
        public string Accountnumber { get; set; }
        public string Accounttype { get; set; }
        public decimal Accountbalance { get; set; }


        public Account(string fullname, string accountnumber, string accounttype, decimal accountbalance)
        {
            Fullname = fullname;
            Accountnumber = accountnumber;
            Accounttype = accounttype;
            Accountbalance = accountbalance;

        }


    }
   
}
