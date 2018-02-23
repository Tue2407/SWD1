using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverPatternHandin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tror stock skal bruges til notifikationsdelen
            Stock stock = new Stock();
            
            //Viser display
            PortfolioDisplay etDisplay = new PortfolioDisplay();
            //Laver et nyt portfolio i listen med navnet Hans, med display
            Portfolio enPortfolio = new Portfolio("Hans", etDisplay);
            //Laver stocks
            ConcreteStocks enStock = new ConcreteStocks("VESTAS", (float)570.50, 1);
            ConcreteStocks toStock = new ConcreteStocks("GOOGLE",(float)943.29, 1);

            //Console.WriteLine(stock);

            etDisplay.PrintPF(enPortfolio);

            //Tilføjer
            Console.WriteLine("\nAdding VESTAS");
            enPortfolio.AddStock(enStock);
            etDisplay.PrintPF(enPortfolio);
            Console.WriteLine("\nAdding GOOGLE");
            enPortfolio.AddStock(toStock);
            etDisplay.PrintPF(enPortfolio);
            //Updatere
            Console.WriteLine("\nUpdating VESTAS");
            enPortfolio.Update(enStock, 400);
            etDisplay.PrintPF(enPortfolio);

;           //Fjerner
            Console.WriteLine("\nRemoving VESTAS");
            enPortfolio.RemoveStock(enStock);
            etDisplay.PrintPF(enPortfolio);



        }
    }

    //Implementation inde i Stocks
    public interface ISubject
    {
        void attach(Portfolio obj);
        void detach(Portfolio obj);
        void notify(ConcreteStocks obj);       
    }

    //Implemnetation inde i Portfolio
    public interface IObserver
    {

        void Update(ConcreteStocks name, float value);
    }


}
