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
        public override string ToString()
        {
            return "Ticker: " + _ticker + " -- Value" + _value;
        }

        public string _ticker { set; get; }


        // EVENTHANDLER FOR STOCK
        public event System.EventHandler ValueChanged;

        protected virtual void OnValueChanged()
        {
            if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
        }

        public float _value
        {
            set
            {
                _value = value;
                OnValueChanged();
            }
            get { return _value; }
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

      
    }

    public class Portfolio
    {
        public List<Stock> stockList = new List<Stock>();

        public Portfolio()
        { }
    }

    public class PortfolioDisplay : Portfolio
    {
        // PRINT STOCK LIST FROM PORTFOLIO

    }
}
