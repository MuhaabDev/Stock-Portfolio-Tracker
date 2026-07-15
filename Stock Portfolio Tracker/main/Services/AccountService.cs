using main.Models;
namespace main.Services;

public class AccountService
{

    List<User> user = new List<User>();
    public  bool checkAccount(string username, string password)
    {
        bool accountFound = false;
        for (int i = 0; i < user.Count(); i++)
        {
            if (username == user[i].username && password == user[i].password)
            {
                accountFound = true;
                Accounts.currentAccount = i;
                break;
            }
        }
        return accountFound;
    }

    public  void RegisterAccount(string username, string password)
    {
        User newUser = new User();
        newUser.username = username;
        newUser.password = password;
        user.Add(newUser);
        Console.WriteLine("Account Created Successfully");
    }

    public  void LogIn() {
        string userName, password;
        Console.Write("Username: ");
        userName = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        if (checkAccount(userName, password))
        {
            Console.WriteLine("Login Succesfully");
            Accounts.loggedIn = true;
        }
        else
        {
            Console.WriteLine("Login Failed");
        }
    }

    public void Register()
    {
        string userName, password;
        Console.WriteLine("Enter Your Username : ");
        userName = Console.ReadLine();
        Console.WriteLine("Enter Your Password : ");
        password = Console.ReadLine();
        RegisterAccount(userName, password);
    }

    public static void CloseProgram() { 
        Accounts.running = false;
    }

}
