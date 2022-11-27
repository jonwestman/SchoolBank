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

            //creating admin at the start
            List<BankAccount> bankAccounts = new List<BankAccount>();

            bankAccounts.Add(new BankAccount("admin", "password"));

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

                if (userName != "admin" || passWord != "1234")
                {
                    ctr++;
                }
                else
                {
                    ctr = 1;
                }

            } while ((userName != "admin" || passWord != "1234") && (ctr != 3));

            if (ctr == 3)
            {
                Console.WriteLine("Login attempt three or more times. You're locked out");
                //password is set to default
                bankAccounts.Remove(new BankAccount(userName, passWord));
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
            string menuInput, theEnd;

            do
            {
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

                Console.WriteLine("Press enter to continue or 'q' to quit");
                theEnd = Console.ReadLine();

            } while (theEnd.ToLower() != "q");

            Console.Clear();

            Console.WriteLine("Great Success");

            Console.ReadKey();
        }
        //swith menu that can be reused
        public static void SwitchMenu(uint approvedInput)
        {
            string theEnd;

            do
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
                Console.WriteLine("Press Enter to continue or 'q' to quit");
                theEnd = Console.ReadLine();

                Console.Clear();

            } while (theEnd.ToLower() != "q");
        }

        public static void AdminMenu()
        {
            uint approvedInput;
            string menuInput, theEnd;

            do
            {


                do
                {
                    do
                    {
                        Console.Clear();
                        string[] menu = new string[3] { "1: Create new user", "2: Update currency exchange rate", "3: Edit user" };

                        for (int i = 0; i < menu.Length; i++)
                        {
                            Console.WriteLine(menu[i]);
                        }
                        menuInput = Console.ReadLine();

                    } while (!uint.TryParse(menuInput, out approvedInput));

                } while (approvedInput >= 4);

                //Calling Admin Switch Menu
                AdminSwitchMenu(approvedInput);

                Console.WriteLine("Press Enter to continue or 'q' to quit");
                theEnd = Console.ReadLine();

                Console.Clear();

            } while (theEnd.ToLower() != "q");
        }
        //Menu when you log in as admin
        public static void AdminSwitchMenu(uint approvedInput)
        {
            string theEnd;
            do
            {
                switch (approvedInput)
                {
                    case 1:
                        Console.WriteLine("Create new user");
                        Console.WriteLine();

                        string userName, initialInput, passWord;
                        decimal initialBalance;
                        do
                        {
                            do
                            {
                                Console.Write("Input username: ");
                                userName = Console.ReadLine();
                            } while (userName == null);

                            Console.WriteLine();

                            do
                            {
                                Console.Write("Input password: ");
                                passWord = Console.ReadLine();
                            } while (passWord == null);

                            Console.WriteLine();

                            do
                            {
                                Console.Write("Input Initial Balance: ");
                                initialInput = Console.ReadLine();
                            } while (!decimal.TryParse(initialInput, out initialBalance));

                            //creating new customer with username, password and initialbalance and add it to the list of bankaccounts
                            List<BankAccount> bankAccounts = new List<BankAccount>();

                            bankAccounts.Add(new BankAccount(userName, passWord, initialBalance));

                            Console.WriteLine("Press Enter to continue or 'q' to quit");
                            theEnd = Console.ReadLine();

                            Console.Clear();

                        } while (theEnd.ToLower() != "q");

                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Update currency exchange rate");

                            Console.WriteLine("Press Enter to continue or 'q' to quit");
                            theEnd = Console.ReadLine();

                        } while (theEnd.ToLower() != "q");
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Edit user");

                            Console.WriteLine("Press Enter to continue or 'q' to quit");
                            theEnd = Console.ReadLine();

                        } while (theEnd.ToLower() != "q");
                        break;
                }

                Console.WriteLine("Press Enter to continue or 'q' to quit");
                theEnd = Console.ReadLine();

                Console.Clear();

            } while (theEnd.ToLower() != "q");
        }
    }
}
