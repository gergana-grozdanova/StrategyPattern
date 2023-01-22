using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class HandmadeCoffee : ICoffeeMaker
    {
        public void Make(string size)
        {
            Console.WriteLine($"{size} made by Geri's hands.");
        }
    }
}
