﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHandin
{
    public class PortfolioDisplay
    {
        public interface IDisplay
        {
            void Update(ConcreteStocks stock);
        }

    }
}
