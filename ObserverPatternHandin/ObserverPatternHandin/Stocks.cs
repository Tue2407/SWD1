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
            //Attributterne
            public string _ticker { set; get; }
            public float _value { set; get; }


            //LAVES en ny liste til stocks
            private List<Portfolio> ObserversList;
            
            public Stock()
            {
                ObserversList = new List<Portfolio>(); 
            }
            //Vi attacher til portfolio
            public void attach(Portfolio obj)
            {
                ObserversList.Add(obj);
            }

            //Vi detacher fra portfolio
            public void detach(Portfolio obj)
            {
                ObserversList.Remove(obj);
            }

        //Når vi notificere observeren, så opdateres der
        /*public void notify()
        {
            foreach (var observers in ObserversList)
            {
                observers.Update(_ticker, _value);
            }
        }*/
        public void notify(ConcreteStocks stock)
        {
            foreach (var observers in ObserversList)
            {
                observers.Update(stock, _value);
            }
        }
        //Her er stock metoden
        public Stock(string ticker, float value)
            {
                _ticker = ticker;
                _value = value;
            }

        /*
            public void changeStockValue(string ticker, float value)
            {
                Console.WriteLine("Enter ticker symbol: ");
                _ticker = Console.ReadLine();
                Console.WriteLine("Enter stock value: ");
                _value = Convert.ToInt32(Console.ReadLine());
            }
            */
            //Vi laver det om til strings
            public override string ToString()
            {
                return "Ticker: " + _ticker + " -- Value: " + _value;
            }
            
            
        }
}
