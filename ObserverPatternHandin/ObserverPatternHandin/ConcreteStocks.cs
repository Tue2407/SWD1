using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ABSTRACT STOCK med al implementering, så vi kun behøver at give valuta og added navnet ind
//Arver fra stock af, så man kun behøver at bruge navn, valuta og antal.
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
        //Hvis noget ændre sig, så bliver det notifikeret/opdateret på den stocks i alle dele af systemet
        public void setValue(float value)
        {
            ValueOfSubject = value;
            notify(this);
        }

        public void setName(string name)
        {
            NameOfSubject = name;
            notify(this);
        }

        public void setAmount(float amount)
        {
            AmountOfSubject = amount;
            notify(this);
        }

        public override string ToString()
        {
            return "Stock: " + NameOfSubject + " -- Value: " + ValueOfSubject;
        }
    }
}
