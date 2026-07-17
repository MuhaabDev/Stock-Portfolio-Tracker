using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Models
{
    public class Portfolio
    {
        public decimal cash { get; set; }
        public List<StockHolding> Holdings { get; set; } = new();

        public decimal DisplayCash()
        {
            return cash;
        }
        public void AddCash(decimal amount)
        {
            cash += amount;
        }
    }
}
/*
 User
    │
    ▼
Portfolio
    │
    ▼
List<StockHolding>

StockHolding
    ├── Stock
    ├── Quantity
    └── AverageBuyPrice

Stock
    ├── Symbol
    ├── Name
    └── CurrentPrice
 */