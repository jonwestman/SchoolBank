using System;
using System.Collections.Generic;
using System.Text;
using Figgle;

namespace BankOfEdugrade
{
    class BankSystem
    {
        //Bank logo displayed using ACII-art
        public static void BankLogo()
        {
            Console.WriteLine(FiggleFonts.Fender.Render("Bank of Edugrade"));
        }
        //Initial Login to Bank
        public static void LoginMenu()
        {
            string username, password;
            do
            {
                Console.WriteLine("Please log in using your user credentials");
                do
                {
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                } while (username == null);

                Console.WriteLine();

                do
                {
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                } while (password == null);

                Console.Clear();

            } while (true);
        }
    }
}
