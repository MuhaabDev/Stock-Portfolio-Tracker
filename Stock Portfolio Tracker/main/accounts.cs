namespace main;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Accounts
{
    // --------------------------------------------- Constructor ----------------------------------------------------------- 
    public Accounts(List<User> userss)
    {
        noOfAccounts = 0;
        users = userss;
    }

    // --------------------------------------------- Attributes ------------------------------------------------------------ 
    public int noOfAccounts { get; set; }
    public int currentAccount { get; set; }
    public List<User> users;

    // --------------------------------------------- Functions -------------------------------------------------------------
    public bool checkAccount(string username, string password)
    {
        bool accountFound = false;
        for (int i = 0; i < noOfAccounts; i++)
        {
            if (username == users[i].username && password == users[i].password)
            {
                accountFound = true;
                currentAccount = i;
                break;
            }
        }
        return accountFound;
    }

    
    public  void RegisterAccount(string username, string password)
    {
        // todo : you need to check if the password is strong
        // todo : you need to check if the username is not taken
        User newUser = new User();
        newUser.username = username;
        newUser.password = password;
        users.Add(newUser);
        Console.WriteLine("Account Created Successfully");
        noOfAccounts++;
    }
}

