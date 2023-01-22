using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cm = new CoffeeMachine();
            var maker = new CoffeeMakerContext(cm);
            maker.Make("Big");
        }
    }
}
