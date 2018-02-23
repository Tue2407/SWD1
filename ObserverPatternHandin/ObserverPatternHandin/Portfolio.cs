using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    public class Portfolio : IObserver
    {
        private float TotalValue { get; set; } = 0;
        public string Name { get; set; }
        public List<ConcreteStocks> stockList = new List<ConcreteStocks>();

        public Portfolio(string name)
        {
            Name = name;
        }

        public void Update(ConcreteStocks name, float value)
        {
            TotalValue = 0;
            foreach (var VARIABLE in stockList)
            {
                TotalValue += VARIABLE.ValueOfSubject * VARIABLE.AmountOfSubject;
            }

            foreach (var VARIABLE in stockList)
            {
                if (VARIABLE.NameOfSubject == name.NameOfSubject) //Find navnet på stocken/subject
                {
                    VARIABLE.ValueOfSubject = value; //Override med den nye valuta
                }
            }
        }

        public void AddStock(ConcreteStocks stock)
        {
            stock.attach(this);//Attacher whatever man vil attach, men den skal helst have portfolio ind Ellers dør baby!
            stockList.Add(stock); //Adder stock til listen hvor stock er navn, valuta, og antal
            TotalValue = stock.ValueOfSubject + TotalValue;
        }
        

    }
}
