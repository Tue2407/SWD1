using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Stock
    {
        public string _ticker { set; get; }
        public int _value { set; get; }

        public Stock(string ticker, int value)
        {
            _ticker = ticker;
            _value = value;
        }

        public void setStockValue()
        {

        }
    }

    public class Portfolio
    {
        private List<Stock> stockList = new List<Stock>();
    }

    public class PortfolioDisplay
    {
    }
}
