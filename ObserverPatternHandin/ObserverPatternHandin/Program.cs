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
            var enStock = new ConcreteStocks("Nystocks", 2 , 20); //Lav stock
            var toStock = new ConcreteStocks("Andenstock", 4, 11);
            


            var enPortfolio = new Portfolio("Hans"); //Lav nyt portfolio
            var toPortfolio = new Portfolio("Thomas");
            //Console.WriteLine(enStock);

            Console.WriteLine($"Portfolio af: {enPortfolio.Name} (ligenu)");

            enPortfolio.AddStock(enStock);
            enPortfolio.AddStock(toStock);

            enPortfolio.stockList.ForEach(i => Console.Write("{0}\t", i));


            
            //Console.WriteLine(enPortfolio.Name);
            
            
            enStock.attach(enPortfolio);
            enPortfolio.Update(enStock, 23);
            enStock.attach(toPortfolio);
            enPortfolio.Update(toStock, 30);

            //Console.WriteLine($"{enPortfolio.Name} : {enPortfolio.stockList[0]} : {enPortfolio.stockList[1]}");

            //Console.WriteLine(enStock.AmountOfSubject);
            //obj1.attach(obj2); //Attach til portfolio med nye stock

            //Insert stocks
            Console.WriteLine($"\n{enPortfolio.Name} stocks: (Opdateret)");
            //Udskriv alle stocks
            //obj2.Update("Nystocks",20);
            //obj1.notify();

            //Console.WriteLine(enPortfolio);
            enPortfolio.stockList.ForEach(i => Console.Write("{0}\t", i));
            
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
