using System.Numerics;

namespace main
{
    internal class Program
    {
        
        // todo : you need to find how to create a vector of a class
        static user[] users = new user[10]; // to store the object for each user
        static int noOfAccounts = 0;

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

                    if(checkAccount(userName, password))
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

        static bool checkAccount(string username, string password) {
            bool userNameFound = false, passwordFound = false;
           
            for (int i = 0; i < noOfAccounts; i++)
            {
                if (username == users[i].username) userNameFound = true;
            }

            for (int i = 0; i < noOfAccounts; i++)
            {
                if (password == users[i].password) passwordFound = true;
            }
            return (userNameFound &&  passwordFound);
        }

        static void RegisterAccount(string username, string password) {
            // todo : you need to check if the password is strong
            // todo : you need to check if the username is not taken
            users[noOfAccounts] = new user();
            users[noOfAccounts].username = username;
            users[noOfAccounts].password = password;
            Console.WriteLine("Account Created Successfully");
            noOfAccounts++;
        }
       
    }
}
