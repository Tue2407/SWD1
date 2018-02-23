using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
        public class Stock : ISubject
        {
            private List<Portfolio> ObserversList;

            public void attach(Portfolio obj)
            {
                ObserversList.Add(obj);
            }


            public void detach(Portfolio obj)
            {
                ObserversList.Remove(obj);
            }

            public void notify()
            {
                foreach (var observers in ObserversList)
                {
                    observers.Update(_ticker, _value);
                }
            }

            public string _ticker { set; get; }
            public float _value { set; get; }

            public Stock(string ticker, float value)
            {
                _ticker = ticker;
                _value = value;
            }

            public Stock()
            { }
        /*
            public void changeStockValue(string ticker, float value)
            {
                Console.WriteLine("Enter ticker symbol: ");
                _ticker = Console.ReadLine();
                Console.WriteLine("Enter stock value: ");
                _value = Convert.ToInt32(Console.ReadLine());
            }
            */
            public override string ToString()
            {
                return "Ticker: " + _ticker + " -- Value: " + _value;
            }
        }
}
