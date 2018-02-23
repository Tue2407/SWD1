using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverPatternHandin
{
    class Program
    {

        //Lisbeth tester take 887
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
            
            //hej

        }
    }

    public interface ISubject
    {
        void attach(Portfolio obj);
        void detach(Portfolio obj);
        void notify();       
    }

    public interface IObserver
    {
<<<<<<< HEAD
        public List<Stock> stockList = new List<Stock>();
        //testcomment

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

            //Insert stocks
            Console.WriteLine("Dine stocks:");
            //Udskriv alle stocks
            obj2.stockList.ForEach(i => Console.WriteLine("{0}\t", i));
        }
        //Test somedude
=======
        void Update(string name, float value);
>>>>>>> fcc7f2912015f6d69e830b33af3c9f396463fbcc
    }
}
