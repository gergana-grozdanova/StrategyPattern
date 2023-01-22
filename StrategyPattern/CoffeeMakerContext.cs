using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CoffeeMakerContext
    {
        private readonly ICoffeeMaker _coffeeMaker;
        public CoffeeMakerContext(ICoffeeMaker coffeeMaker)
        {
            _coffeeMaker = coffeeMaker;
        }

        public void Make(string size)
        {
            _coffeeMaker.Make(size);
        }
    }
}
