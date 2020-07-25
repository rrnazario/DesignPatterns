using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Implementations
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }
        public Context(IStrategy strategy) => SetStrategy(strategy);

        public void SetStrategy(IStrategy strategy)
        {
            Console.WriteLine($"Changing strategy to {strategy.GetType().Name}");

            _strategy = strategy;
        }
        public void ShowSetValues()
        {
            var dataSet = new string[] { "a", "b", "c", "d", "e" };
            Console.WriteLine("Results:");
            Console.WriteLine(string.Join(",", _strategy.HandleSet(dataSet)));            
        }
    }
}
