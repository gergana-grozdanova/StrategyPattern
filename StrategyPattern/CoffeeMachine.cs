using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CoffeeMachine : ICoffeeMaker
    {
        public void Make(string size)
        {
            Console.WriteLine($"{size} coffee made by coffee machine.");
        }
    }
}
