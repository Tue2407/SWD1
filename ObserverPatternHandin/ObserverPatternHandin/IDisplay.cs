using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fordi IDisplay er bare et interface og burde køre således med alle interfaces!

namespace ObserverPatternHandin
{
    public interface IDisplay
    {
        void PrintPF(Portfolio port);
    }
}
