using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfEdugrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //displaying bank logo
            BankSystem.BankLogo();

            //Logging in to system with user credentials
            BankSystem.LoginMenu();

        }
    }
}
