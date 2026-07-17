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
        StockService stockService = new StockService();
        Settings settings = new Settings(users);
        PortfolioService portfolioService;

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
                        portfolioService = new PortfolioService(users[Accounts.currentAccount]);
                        int op2 = 0;
                        while(op2 != 5)
                        {
                            op2 = UserService.displayTradingService();
                            switch (op2) {
                                case 1:
                                    portfolioService.DisplayUserStocks();
                                    break;
                                case 2:
                                    stockService.DisplayAvailableStocks();
                                    break;
                                case 3:
                                    var (symbol, quantity) = portfolioService.GetStockOrder(); 
                                    portfolioService.BuyStocks(symbol , quantity);
                                    dataService.SaveUsers(users);
                                    break;
                                case 4:
                                    var (symboll, quantityy) = portfolioService.GetStockOrder(); 
                                    portfolioService.SellStocks(symboll , quantityy);
                                    dataService.SaveUsers(users);
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input , Try Again");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        settings.DisplaySettings();
                        dataService.SaveUsers(users);
                        break;
                    case 5:
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

