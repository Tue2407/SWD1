using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    //Implementation inde i Stocks (Fordi vores Subject er stock)
    public interface ISubject
    {
        void attach(Portfolio obj);
        void detach(Portfolio obj);
        void notify(ConcreteStocks obj);
    }
}
