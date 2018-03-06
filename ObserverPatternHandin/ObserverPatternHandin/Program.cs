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
            var enStock = new ConcreteStocks("VESTAS", 570.50, 1);
            var toStock = new ConcreteStocks("GOOGLE",943.29, 1);

            //Console.WriteLine(stock);

            //etDisplay.PrintPF(enPortfolio);

            
            //Tilføjer
            //Console.WriteLine("\nAdding VESTAS");
            enPortfolio.AddStock(enStock);
            //etDisplay.PrintPF(enPortfolio);
            //Console.WriteLine("\nAdding GOOGLE");
            enPortfolio.AddStock(toStock);
            //etDisplay.PrintPF(enPortfolio);
            toPortfolio.AddStock(enStock);
            
            //Updatere
             Random number = new Random();
            int counter = 0;

            while (counter < 5)
            {
                
                Thread.Sleep(1000);
                double number1 = number.NextDouble() * (enStock.ValueOfSubject * 1.05 - enStock.ValueOfSubject * 0.95) + enStock.ValueOfSubject * 0.95; //Det her giver mig mellem 95 og 105 procent
                enStock.setValue(number1);

                counter++;
            }
            
            //Console.WriteLine("\nUpdating VESTAS");
            //etDisplay.PrintPF(enPortfolio);
            //etDisplay.PrintPF(toPortfolio);

            //Notifikation
            //Console.WriteLine("\nNotifikation: Ændring af VESTAS til DINMOR");
            enStock.setName("DINMOR");
            //etDisplay.PrintPF(enPortfolio);
            
            //etDisplay.PrintPF(toPortfolio);

;           //Fjerner
            //Console.WriteLine("\nRemoving VESTAS");
            enPortfolio.RemoveStock(enStock);
            //etDisplay.PrintPF(enPortfolio);
            while (counter < 10)
            {

                Thread.Sleep(1000);
                double number1 = number.NextDouble() * (toStock.ValueOfSubject * 1.05 - toStock.ValueOfSubject * 0.95) + toStock.ValueOfSubject * 0.95; //Det her giver mig mellem 95 og 105 procent
                toStock.setValue(number1);

                counter++;
            }

        }
    }
}
