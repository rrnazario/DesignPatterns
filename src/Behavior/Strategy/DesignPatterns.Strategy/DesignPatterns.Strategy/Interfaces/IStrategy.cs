using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Interfaces
{
    public interface IStrategy
    {
        /// <summary>
        /// Will change set values, order, etc.
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        IEnumerable<string> HandleSet(IEnumerable<string> dataSet);
    }
}
