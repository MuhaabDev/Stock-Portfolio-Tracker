using main.Models;
using System.Security.Cryptography.X509Certificates;
namespace main.Services;

public class PortfolioService
{
    User currentUser;
    StockService StockService = new StockService();
    public PortfolioService(User user) { 
        currentUser = user;
    }

    public void DisplayUserStocks()
    {
        Console.WriteLine("User Stocks\r\n----------------------------------");
        if(currentUser.portfolio.Holdings.Count == 0)
        {
            Console.WriteLine("Portfolio Is Empty");
            return;
        }
        foreach (var s in currentUser.portfolio.Holdings)
        {
            if(s.Quantiy > 0)
            {
                Console.WriteLine($"{s.stock.Symbol}\t{s.stock.Name}\t{s.Quantiy}\t${s.AverageBuyPrice}\t${s.Quantiy*s.AverageBuyPrice}");
            }
        }
    }

    public (string Symbol, int Quantity) GetStockOrder()
    {
        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine()!.Trim().ToUpper();

        Console.Write("Enter Quantity: ");
        int quantity = int.Parse(Console.ReadLine()!);

        return (symbol, quantity);
    }

    public StockHolding? findUserStock(string symbol)
    {
        StockHolding stock = null;
        foreach (var s in currentUser.portfolio.Holdings) { 
            if(symbol == s.stock.Symbol)
            {
                stock = s;
            }
        }
        return stock;

    }

    public void BuyStocks(string symbol , int quantity)
    {
        Stock stock = StockService.FindStock(symbol);
        if (stock != null) {
            if (stock.Price * quantity <= currentUser.portfolio.cash) { 
                StockHolding stockHolding = new StockHolding();
                stockHolding.stock = stock;
                stockHolding.Quantiy += quantity;
                stockHolding.AverageBuyPrice = stock.Price;
                currentUser.portfolio.Holdings.Add(stockHolding);
                currentUser.portfolio.cash -= quantity*stock.Price;
                Console.WriteLine($"Bought {quantity} of {symbol} Successfully , Cash Left : ${currentUser.portfolio.cash}");
            }
            else
            {
                Console.WriteLine($"You Don't Have Enough Money");
            }
        }
        else
        {
            Console.WriteLine("Stock Doesn't Exist");
        }
    }

    public void SellStocks(string symbol, int quantity) {
        StockHolding stockHolding = findUserStock(symbol);
        if (stockHolding != null) {
            if (quantity <= stockHolding.Quantiy) {
                stockHolding.Quantiy -= quantity;
                currentUser.portfolio.cash += quantity * stockHolding.stock.Price;
                Console.WriteLine($"{quantity} of {stockHolding.stock.Symbol} sold Successfully , Got {stockHolding.Quantiy} left");
            }
            else
            {
                Console.WriteLine($"Failed , You only Got {stockHolding.Quantiy}");
            }
        }
        else
        {
            Console.WriteLine("Stock Doesn't Exist");
        }
    }
}
