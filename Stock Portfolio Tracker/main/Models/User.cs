namespace main.Models;

using main.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    public ConsoleColor SelectedColor = ConsoleColor.White; //Default
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
