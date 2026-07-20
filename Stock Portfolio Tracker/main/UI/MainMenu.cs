namespace main.UI;
using main.Models;
using main.Services;
public class MainMenu
{
    public void StartProgram(List<User> users , DataService dataService)
    {
        displayHeader();

        AccountMenu accountMenu;
        UserMenu userMenu;

        while (Accounts.running)
        {
            if (Accounts.loggedIn) //Show User Menu
            {
                userMenu = new UserMenu(users, dataService);
                userMenu.Show();
            }
            else // Register/Login
            {
                accountMenu = new AccountMenu(users);
                accountMenu.Show();
            }
        }
    }

    public void displayHeader()
    {
        Console.Title = "Stock Portfolio Tracker";
        Console.WriteLine("==========================================================");
        Console.WriteLine("               Welcome To Stock Portfolio Tracker");
        Console.WriteLine("==========================================================");
    }
}
