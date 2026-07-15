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
        private decimal cash { get; set; }
        public List<Stock> Holdings { get; set; } = new();

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
