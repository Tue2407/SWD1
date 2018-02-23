using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    public class Portfolio : IObserver
    {
        public List<Stock> stockList = new List<Stock>();

        public Portfolio()
        { }
    }
}
