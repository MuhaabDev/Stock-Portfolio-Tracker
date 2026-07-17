using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.Models
{
    public class StockHolding
    {
        public Stock stock { get; set; }
        public int Quantiy {  get; set; }
        public decimal AverageBuyPrice { get; set; }

    }
}
