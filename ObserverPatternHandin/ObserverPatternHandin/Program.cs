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
        public string _ticker
        {
            get => _ticker;
            set => _ticker = value;
        }

        public float _value
        {
            get => _value;
            set => _value = value;
        }

        public Stock(string ticker, float value)
        {
            _ticker = ticker;
            _value = value;
        }

        public Stock()
        { }

        public void changeStockValue(string ticker, float value)
        {
            Console.WriteLine("Enter ticker symbol: ");
            _ticker = Console.ReadLine();
            Console.WriteLine("Enter stock value: ");
            _value = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Ticker: " + _ticker + " -- Value: " + _value;
        }
    }

    public class Portfolio
    {
        public List<Stock> stockList = new List<Stock>();

        public Portfolio()
        { }
    }

    public class PortfolioDisplay
    {

    }
}
