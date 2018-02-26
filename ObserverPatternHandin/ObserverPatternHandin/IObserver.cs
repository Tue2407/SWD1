using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    //Implemnetation inde i Portfolio (Fordi vores Observer er Portfolio)
    public interface IObserver
    {

        void Update(ConcreteStocks name);
    }
}
