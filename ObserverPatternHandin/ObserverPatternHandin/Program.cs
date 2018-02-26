using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;


namespace ObserverPatternHandin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tror stock skal bruges til notifikationsdelen
            var stock = new Stock();
            
            //Viser display
            var etDisplay = new PortfolioDisplay();
            //Laver et nyt portfolio i listen med navnet Hans, med display
            var enPortfolio = new Portfolio("Hans", etDisplay);
            var toPortfolio = new Portfolio("Eckhart", etDisplay);
            //Laver stocks
            var enStock = new ConcreteStocks("VESTAS", (float)570.50, 1);
            var toStock = new ConcreteStocks("GOOGLE",(float)943.29, 1);

            //Console.WriteLine(stock);

            //etDisplay.PrintPF(enPortfolio);

            
            //Tilføjer
            Console.WriteLine("\nAdding VESTAS");
            enPortfolio.AddStock(enStock);
            //etDisplay.PrintPF(enPortfolio);
            Console.WriteLine("\nAdding GOOGLE");
            enPortfolio.AddStock(toStock);
            //etDisplay.PrintPF(enPortfolio);
            toPortfolio.AddStock(enStock);
            Thread.Sleep(5000);
            //Updatere
            enStock.setValue(1000);
            Console.WriteLine("\nUpdating VESTAS");
            //etDisplay.PrintPF(enPortfolio);
            //etDisplay.PrintPF(toPortfolio);

            //Notifikation
            Console.WriteLine("\nNotifikation: Ændring af VESTAS til DINMOR");
            enStock.setName("DINMOR");
            //etDisplay.PrintPF(enPortfolio);
            
            //etDisplay.PrintPF(toPortfolio);

;           //Fjerner
            Console.WriteLine("\nRemoving VESTAS");
            enPortfolio.RemoveStock(enStock);
            //etDisplay.PrintPF(enPortfolio);
            
        }
    }
}
