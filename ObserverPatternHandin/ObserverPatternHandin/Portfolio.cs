using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Den arver fra IObserver så den kan notificere og afbenytte sig af de stocks der er inde i systemet.
//Her bliver Stocks tilknyttet og behaviour bliver defineret alt efter hvad Portfolio har brug for.

namespace ObserverPatternHandin
{
    public class Portfolio : IObserver
    {
        private IDisplay Display;
        private float TotalValue { get; set; } = 0;
        public string Name { get; set; }
        public List<ConcreteStocks> stockList = new List<ConcreteStocks>();

        public Portfolio(string name, IDisplay display)
        {
            Name = name;
            Display = display;
        }

        public void Update(ConcreteStocks name)
        {
            TotalValue = 0;
            foreach (var VARIABLE in stockList)
            {
                TotalValue += VARIABLE.ValueOfSubject * VARIABLE.AmountOfSubject;
            }

            foreach (var VARIABLE in stockList)
            {
                if(VARIABLE.NameOfSubject == name.NameOfSubject)
                Display.PrintPF(this);
            }

            foreach (var VARIABLE in stockList)
            {
                if (VARIABLE.NameOfSubject == name.NameOfSubject) //Find navnet på stocken/subject
                {
                    VARIABLE.ValueOfSubject =
                        VARIABLE.ValueOfSubject * VARIABLE.AmountOfSubject; //Override med den nye valuta ganget ind med antallet af aktier man har
                }
            }
        }

        public void AddStock(ConcreteStocks stock)
        {
            stock.attach(this);//Attacher whatever man vil attach, men den skal helst have portfolio ind Ellers dør baby!
            stockList.Add(stock); //Adder stock til listen hvor stock er navn, valuta, og antal
            TotalValue = stock.ValueOfSubject + TotalValue;
        }

        public void RemoveStock(ConcreteStocks stock)
        {
            stock.detach(this);
            stockList.Remove(stock);
            TotalValue = stock.ValueOfSubject * 0;
        }

    }
}
