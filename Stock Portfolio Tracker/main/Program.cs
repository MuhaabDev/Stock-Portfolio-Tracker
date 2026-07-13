using System.Numerics;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"---------------------------------------------------------------------
               Welcome To Stock Portfolio Tracker");

            bool working = true;
            while(working)
            {
                Console.WriteLine("1: Login \t\t 2: Register \t\t 3: Exit");
                int op = int.Parse(Console.ReadLine());

                // todo : you need to find how to create a vector of a class
                user[] users = new user[10]; // to store the object for each user
                int noOfAccounts = 0;

                if (op == 1)
                {
                    bool userNameFound = false, passwordFound = false;
                    Console.Write("Username: ");
                    string userName = Console.ReadLine();
                    for(int i = 0; i < noOfAccounts; i++)
                    {
                        if(userName == users[i].username)
                        {
                            userNameFound = true;
                        }
                    }
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    for (int i = 0; i < noOfAccounts; i++)
                    {
                        if (password == users[i].password)
                        {
                            passwordFound = true;
                        }
                    }

                    if(userNameFound && passwordFound)
                    {
                        Console.WriteLine($"You Have Loged In Successfuly , Welcome {userName}");
                    }
                    else
                    {
                        if (!userNameFound)
                        {
                            Console.WriteLine("This Username doesnt Exist , Try Again");
                        }else
                        {
                            Console.WriteLine("Wrong Password");
                        }
                    }
                }
                else if (op == 2)
                {
                    // todo : you need to check if the username is not taken
                    Console.WriteLine("Enter Your Username : ");
                    string userName = Console.ReadLine();

                    // todo : you need to check if the password is strong
                    Console.WriteLine("Enter Your Password : ");
                    string password = Console.ReadLine();

                    users[noOfAccounts] = new user();
                    users[noOfAccounts].username = userName;
                    users[noOfAccounts].password = password;
                    Console.WriteLine("Account Created Successfully");
                    noOfAccounts++;
                    
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
