using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Implementations.Strategies
{
    public class StrategyDefault : IStrategy
    {
        public IEnumerable<string> HandleSet(IEnumerable<string> dataSet) => dataSet;
    }
}
