namespace main.Models;

using main.Services;
using System;

public class User
{
    public ConsoleColor? SelectedColor;
    public string username { get; set; }
    public string password { get; set; }
    public Portfolio portfolio { get; set; } = new Portfolio();
}
/*
User
 ├── Username
 ├── Password
 └── Portfolio
       ├── Cash
       └── Holdings
            ├── AAPL
            ├── TSLA
            └── NVDA
 */
