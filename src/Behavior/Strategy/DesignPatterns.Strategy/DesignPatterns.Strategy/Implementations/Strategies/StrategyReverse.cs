using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy.Implementations.Strategies
{
    public class StrategyReverse : IStrategy
    {
        public IEnumerable<string> HandleSet(IEnumerable<string> dataSet) => dataSet.Reverse();
    }
}
