using main.Models;
using System.Drawing;

namespace main.Services;

public class UserService
{
    int UserId { get; set; }
    public List<User> users { get; set; };
    public UserService( List<User> user , int currentAccount)
    {
        UserId = currentAccount;
        users = user;

    }
    public static int displayUserService()
    {
        Console.WriteLine("1: Display Cash Balance \t\t 2: add Balance \t\t 3: Logout");
        var isSuccesful = int.TryParse(Console.ReadLine(), out int op);
        return op;
    }

    public void displayBalance()
    {
        decimal currentBalance = users[Accounts.currentAccount].portfolio.DisplayCash();
        Console.WriteLine($"Current Balance : {currentBalance}");
    }

    public void AddMoney()
    {
        Console.WriteLine("Enter The Amount you Want to Add");
        var isSuccesful = decimal.TryParse(Console.ReadLine(), out decimal amount);
        users[Accounts.currentAccount].portfolio.AddCash(amount);
    }



}
