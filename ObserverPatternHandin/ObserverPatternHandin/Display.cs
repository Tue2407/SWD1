using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
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
