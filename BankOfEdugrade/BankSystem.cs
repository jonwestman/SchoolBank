using System;
using System.Collections.Generic;
using System.Text;

namespace BankOfEdugrade
{
    class BankSystem
    {
        public BankSystem()
        {

        }
       
        public static void Login()
        {

            //Method for checking logging in and checking credentials

            string userName, passWord;
            int ctr = 0;

            Console.WriteLine("Welcome");
            Console.WriteLine("Please log in using Username and Password");
            Console.WriteLine("Default Username and Password is: abcd and 1234");
            Console.WriteLine("---------------------------------------------------");

            do
            {
                Console.Write("Username: ");
                userName = Console.ReadLine();

                Console.Write("Password: ");
                passWord = Console.ReadLine();

                if (userName != "abcd" || passWord != "1234")
                {
                    ctr++;
                }
                else
                {
                    ctr = 1;
                }

            } while ((userName != "abcd" || passWord != "1234") && (ctr != 3));

            if (ctr == 3)
            {
                Console.WriteLine("Login attempt three or more times. You're locked out");
            }
            else
            {
                Console.WriteLine("Login Successfull");
                Menu();
            }
        }

        public static void Menu()
        {

            //Method for printing out menu and handling input

            uint approvedInput;
            string menuInput;

            do
            {
                do
                {
                    Console.Clear();
                    string[] menu = new string[9] { "1: View Amount on all Accounts", "2: Transfer money between Accounts", "3: Transfer money to Other Customers", "4: Open new Account", "5: View Amount in Other Currency", "6: Open Savings Account", "7: Apply for Loan", "8: View all you transactions", "9: Quit" };

                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine(menu[i]);
                    }
                    menuInput = Console.ReadLine();

                } while (!uint.TryParse(menuInput, out approvedInput));

            } while (approvedInput >= 10);

            Console.Clear();

            Console.WriteLine("Great Success");

            Console.ReadKey();
        }
    }
}
