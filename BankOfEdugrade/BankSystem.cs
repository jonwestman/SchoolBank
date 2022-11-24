using System;
using System.Collections.Generic;
using System.Text;
using Figgle;

namespace BankOfEdugrade
{
    class BankSystem
    {
        public static void Login()
        {

            //Method for checking login and checking credentials

            string userName, passWord;
            int ctr = 0;

            Console.WriteLine(FiggleFonts.Fender.Render("Bank Of Edugrade"));
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
                //password is set to default
            }
            else if (userName == "admin")
            {
                //Login was successfull transfer admin to admin menu
                AdminMenu();
            }
            else
            {
                //Login was successfull transfer admin to customer menu
                CustomerMenu();
            }
        }

        public static void CustomerMenu()
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

            //calling switch menu with method
            SwitchMenu(approvedInput);

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Great Success");

            Console.ReadKey();
        }
        //swith menu that can be reused
        public static void SwitchMenu(uint approvedInput)
        {
            switch (approvedInput)
            {
                case 1:
                    Console.WriteLine("Case 1 - Amount on all of your accounts");
                    break;
                case 2:
                    Console.WriteLine("Case 2 - Transfer money between your accounts");
                    break;
                case 3:
                    Console.WriteLine("Case 3 - Transfer money to another customer");
                    break;
                case 4:
                    Console.WriteLine("Case 4 - Open new account");
                    break;
                case 5:
                    Console.WriteLine("Case 5 - View amount in other currency");
                    break;
                case 6:
                    Console.WriteLine("Case 6 - Open up savings account");
                    break;
                case 7:
                    Console.WriteLine("Case 7 - Apply for loan");
                    break;
                case 8:
                    Console.WriteLine("Case 8 - View history of all your transactions");
                    break;
                case 9:
                    Console.WriteLine("Case 9 - Quit");
                    break;
            }
        }
        public static void AdminMenu()
        {
            uint approvedInput;
            string menuInput;

            do
            {
                do
                {
                    Console.Clear();
                    string[] menu = new string[3] {"1: Skapa nya användare", "2: Uppdatera växelkurs", "3: Redigera användare"};

                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine(menu[i]);
                    }
                    menuInput = Console.ReadLine();

                } while (!uint.TryParse(menuInput, out approvedInput));

            } while (approvedInput >= 4);
        }
    }
}
