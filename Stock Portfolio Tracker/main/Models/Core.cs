namespace main.Models;
using System.Collections.Generic;
using Services;
static class Core
{
    public static void RunProgram()
    {
        DataService dataService = new DataService();
        List<User> users = dataService.LoadUsers();
        AccountService accountService = new AccountService(users);
        UserService userService = new UserService(users);
        Settings settings = new Settings(users);

        Console.WriteLine(@"---------------------------------------------------------------------
        Welcome To Stock Portfolio Tracker");

        while (Accounts.running)
        {
            if (Accounts.loggedIn)
            {
                Console.ForegroundColor = users[Accounts.currentAccount].SelectedColor;
                int op1 = UserService.displayUserService();
                switch (op1) {
                    case 1:
                        userService.displayBalance();
                        break;
                    case 2:
                        userService.AddMoney();
                        dataService.SaveUsers(users);
                        break;
                    case 3:
                        settings.DisplaySettings();
                        dataService.SaveUsers(users);
                        break;
                    case 4:
                        Accounts.loggedIn = false;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.WriteLine("1: Login \t\t 2: Register \t\t 3 : Exit");
                var isSuccesfull = int.TryParse(Console.ReadLine() , out int op);
                switch (op)
                {
                    case 1:
                        accountService.LogIn();
                        break;
                    case 2:
                        accountService.Register();
                        dataService.SaveUsers(users);
                        break;
                    case 3:
                        AccountService.CloseProgram();
                        break;
                    default:
                        Console.WriteLine("Wrong input :( , Try Again !");
                        break;
                }
            }
        }
    }
}

