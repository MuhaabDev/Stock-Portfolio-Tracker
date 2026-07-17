using main.Models;
using System.Drawing;

namespace main.Services;

public class UserService
{
    private int userId { get; set; }
    public List<User> users;
    public UserService(List<User> user)
    {
        users = user;
    }
    public static int displayUserService()
    {
        Console.WriteLine("[1]: Display Cash Balance \t\t [2]: add Balance \t\t [3]: Trade \t\t [4]: Settings \t\t [5]: Logout");
        var isSuccesful = int.TryParse(Console.ReadLine(), out int op);
        return op;
    }
    public static int displayTradingService()
    {
        Console.WriteLine("[1]: User Portfolio \t\t [2]: Stocks \t\t [3]: Buy \t\t [4]: Sell \t\t [5]: Exit");
        var tr = int.TryParse(Console.ReadLine(), out int op);
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
