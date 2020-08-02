using DesignPatterns.Strategy.Implementations;
using DesignPatterns.Strategy.Implementations.Strategies;
using DesignPatterns.Strategy.Interfaces;
using System;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== STRATEGY ====");
            
            var context = new Context();
            
            var strategies = new IStrategy[]
            {
                new StrategyDefault(),
                new StrategyReverse()
            };

            foreach (var strategy in strategies)
            {                
                context.SetStrategy(strategy); //With different implementations when will be reasonable, you can change between them.
                context.ShowSetValues();
            }
        }
    }
}
