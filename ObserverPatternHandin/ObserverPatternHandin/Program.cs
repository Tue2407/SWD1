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

        void Update(string name, float value);
    }


}
