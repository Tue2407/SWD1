using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ABSTRACT STOCK med al implementering, så vi kun behøver at give valuta og added navnet ind
namespace ObserverPatternHandin
{
    public class ConcreteStocks : Stock
    {
        public float ValueOfSubject { get; set; }
        public string NameOfSubject { get; set; }
        public float AmountOfSubject { get; set; }

        public ConcreteStocks(string name, float value, float amount)
        {
            NameOfSubject = name;
            ValueOfSubject = value;
            AmountOfSubject = amount;
        }
        public override string ToString()
        {
            return "Ticker: " + NameOfSubject + " -- Value: " + ValueOfSubject;
        }
    }
}
