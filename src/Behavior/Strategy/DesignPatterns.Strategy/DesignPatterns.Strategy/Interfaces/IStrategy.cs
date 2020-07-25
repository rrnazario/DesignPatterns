using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface IStrategy
    {
        IEnumerable<string> HandleSet(IEnumerable<string> dataSet);
    }
}
