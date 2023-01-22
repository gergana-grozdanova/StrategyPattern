using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    interface ICoffeeMaker
    {
        void Make(string size);
    }
}
