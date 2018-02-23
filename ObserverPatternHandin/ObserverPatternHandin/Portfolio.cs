using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    public class Portfolio : IObserver
    {
        public void Update(string name, float value)
        {
            foreach (var VARIABLE in stockList)
            {
                if (VARIABLE._ticker == name)
                {
                    VARIABLE._value = value;
                }
            }
        }

        public List<Stock> stockList = new List<Stock>();

    }
}
