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
        public float _value { set; get; }

        public Stock(string ticker, float value)
        {
            _ticker = ticker;
            _value = value;
        }

        public void changeStockValue(string ticker, float value)
        {
            Console.WriteLine("Enter ticker symbol: ");
            _ticker = Console.ReadLine();
            Console.WriteLine("Enter stock value: ");
            _value = Convert.ToInt32(Console.ReadLine());
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
