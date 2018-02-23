using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Display skal håndtere selve outputs der skal fremvises i vores main
//Den indeholder PrintPF (for PortFolio) og den arver update() fra IDisplay
namespace ObserverPatternHandin
{
    public class PortfolioDisplay : IDisplay
    {
        

        public void PrintPF(Portfolio port)
        {
            Console.WriteLine($"Portfolio: {port.Name}");
            port.stockList.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine("\n");
            
        }
    }
}
