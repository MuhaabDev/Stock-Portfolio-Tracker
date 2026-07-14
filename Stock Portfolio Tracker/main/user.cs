namespace main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class User
{
    public string username {  get; set; }
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
