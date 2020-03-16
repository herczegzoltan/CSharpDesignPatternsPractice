using System;

namespace CSharpDesignPatternsPractice.StrategyPattern
{
    partial class StrategyContext
    {
        public class ConcreteStrategyA : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
            }
        }
    }
}
