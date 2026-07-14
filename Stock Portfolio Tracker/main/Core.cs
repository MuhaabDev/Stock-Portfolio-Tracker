namespace main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Core
{
    public static void RunProgram()
    {
        List<User> user = new List<User>();
        Accounts accountManager = new Accounts(user);

        Console.WriteLine(@"---------------------------------------------------------------------
        Welcome To Stock Portfolio Tracker");

        bool running = true;
        bool loggedIn = false;
        string userName, password;
        int currentAccount = 0;
        while (running)
        {
            if (loggedIn)
            {
                Console.WriteLine("1: Display Cash Balance \t\t 2: add Balance \t\t 3: Logout");
                int op1 = int.Parse(Console.ReadLine());

                switch (op1) {
                
                    case 1:
                        decimal currentBalance = user[currentAccount].portfolio.DisplayCash();
                        Console.WriteLine($"Current Balance : {currentBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount you Want to Add");
                        decimal amount = (decimal)int.Parse(Console.ReadLine());
                        user[currentAccount].portfolio.AddCash(amount);
                        break;
                    case 3:
                        loggedIn = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("1: Login \t\t 2: Register \t\t 3: Exit");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: // Case Login
                        Console.Write("Username: ");
                        userName = Console.ReadLine();
                        Console.Write("Password: ");
                        password = Console.ReadLine();

                        if (accountManager.checkAccount(userName, password))
                        {
                            Console.WriteLine("Login Succesfully");
                            loggedIn = true;
                            currentAccount = accountManager.currentAccount;
                        }
                        else
                        {
                            Console.WriteLine("Login Failed");
                        }
                        break;

                    case 2:  // Case Register
                        Console.WriteLine("Enter Your Username : ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Enter Your Password : ");
                        password = Console.ReadLine();
                        accountManager.RegisterAccount(userName, password);
                        break;

                    case 3:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input :( , Try Again !");
                        break;
                }
            }
        }
    }
}

