using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class accounts
    {
        // --------------------------------------------- Constructor ----------------------------------------------------------- 
        public accounts(List<user> userss)
        {
            noOfAccounts = 0;
            users = userss;
        }

        // --------------------------------------------- Attributes ----------------------------------------------------------- 
        public static int noOfAccounts { get; set; }
        public static List<user> users;

        // --------------------------------------------- Functions ----------------------------------------------------------- 
        public static bool checkAccount(string username, string password)
        {
            bool userNameFound = false, passwordFound = false;

            for (int i = 0; i < noOfAccounts; i++)
            {
                if (username == users[i].username) userNameFound = true;
            }

            for (int i = 0; i < noOfAccounts; i++)
            {
                if (password == users[i].password) passwordFound = true;
            }
            return (userNameFound && passwordFound);
        }

        public static void RegisterAccount(string username, string password)
        {
            // todo : you need to check if the password is strong
            // todo : you need to check if the username is not taken
            user newUser = new user();
            newUser.username = username;
            newUser.password = password;
            users.Add(newUser);
            Console.WriteLine("Account Created Successfully");
            noOfAccounts++;
        }
    }
}
