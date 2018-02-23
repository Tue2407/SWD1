using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
        public class Stock : ISubject
        {
            public void registerObserver()
            {
                //We do not know
            }

            public void removeObserver()
            {
                //Wut?
            }

            public void notifyObserver()
            {
                //Okay?
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
}
