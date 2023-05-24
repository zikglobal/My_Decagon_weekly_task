using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Design;

namespace Calculator
{
    public class Program
    {

        public static void Main(string[] args)

        {

            PrintTable printTable = new PrintTable();
            printTable.mySolutions();

            //Program gpas = new Program();
            //gpas.GPAstats();
        }
    }
}
