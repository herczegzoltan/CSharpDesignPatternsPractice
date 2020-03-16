using System;

namespace CSharpDesignPatternsPractice.StrategyPattern
{
    partial class StrategyContext
    {
        public class ConcreteStrategyB : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
            }
        }
    }
}
