namespace main.Models;
using System.Collections.Generic;
using Services;
static class Core
{
    public static void RunProgram()
    {
        UserService userService;
        AccountService accountService = new AccountService();

        Console.WriteLine(@"---------------------------------------------------------------------
        Welcome To Stock Portfolio Tracker");

        while (Accounts.running)
        {
            if (Accounts.loggedIn)
            {
                int op1 = UserService.displayUserService();
                switch (op1) {
                
                    case 1:
                        
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        Accounts.loggedIn = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("1: Login \t\t 2: Register \t\t 3: Settings \t\t 4: Exit");
                var isSuccesfull = int.TryParse(Console.ReadLine() , out int op);
                switch (op)
                {
                    case 1:
                        accountService.LogIn();
                        break;

                    case 2:
                        accountService.Register();
                        break;
                    case 3:
                        Settings.DisplaySettings();
                        break;
                    case 4:
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

