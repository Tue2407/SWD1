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
            /*Stock obj1 = new Stock();
            var name = obj1._ticker = "Nystock";
            var value = obj1._value = 5;
            Portfolio obj2 = new Portfolio();
            obj2.stockList = new List<Stock>();
            obj2.stockList.Add(obj1);*/
            PortfolioDisplay obj3 = new PortfolioDisplay();
            obj3.Display();
            //Virker
            //Console.WriteLine($"{name} : {value} : {obj2.stockList[0]}");
            
            

        }
    }

    public interface ISubject
    {
        IObserver registerObserver();
        IObserver removeObserver();
        IObserver notifyObserver();


    }

    public interface IObserver
    {
        //Update() typen data
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
            Stock obj1 = new Stock();
            Portfolio obj2 = new Portfolio();
            obj2.stockList = new List<Stock>();
            obj2.stockList.Add(obj1);
            //test23
            //Insert stocks
            Console.WriteLine("Dine stocks:");
            //Udskriv alle stocks
            obj2.stockList.ForEach(i => Console.WriteLine("{0}\t", i));
        }
        //Test somedude
    }
}
