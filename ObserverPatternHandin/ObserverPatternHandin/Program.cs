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
            Stock obj = new Stock();
            var name = obj._ticker = "Nystock";
            var value = obj._value = 5;
            //Stack overflow exception
            Console.WriteLine($"{name} : {value}");
            

        }
    }

    public class Stock
    {
        public event System.EventHandler ValueChanged;


        protected virtual void OnValueChanged()
        {
            if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
        }

        public string _ticker { set; get; }


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
        public void Display()
        {
            
            Portfolio obj = new Portfolio();
            //var value = obj.stockList[1]._value;
            
            //Insert stocks
            Console.WriteLine("Dine stocks:");
            //Udskriv alle stocks
            obj.stockList.ForEach(i => Console.Write("{0}\t", i));
        }
        //Test somedude
    }
}
