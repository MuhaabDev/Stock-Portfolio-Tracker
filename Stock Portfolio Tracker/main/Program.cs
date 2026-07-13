using main;
using System.Collections.Generic;
using System.Numerics;

namespace main
{
    internal class Program
    {
        static List<user> users = new List<user>(); 
        static accounts account = new accounts(users);

        static void Main(string[] args)
        {
            Console.WriteLine(@"---------------------------------------------------------------------
               Welcome To Stock Portfolio Tracker");

            bool working = true;
            while(working)
            {
                Console.WriteLine("1: Login \t\t 2: Register \t\t 3: Exit");
                int op = int.Parse(Console.ReadLine());

                if (op == 1) // Login
                {
                    Console.Write("Username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    if(account.checkAccount(userName , password))
                    {
                        Console.WriteLine("Login Succesfully");
                    }
                    else
                    {
                        Console.WriteLine("Login Failed");
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Enter Your Username : ");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter Your Password : ");
                    string password = Console.ReadLine();
                    RegisterAccount(userName, password);        
                }
                else if (op == 3)
                {
                    working = false;
                }
                else
                {
                    Console.WriteLine("Wrong input :( , Try Again !");
                }
            }
        }
    }
}
