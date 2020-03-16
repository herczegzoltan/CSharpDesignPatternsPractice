using System;

namespace CSharpDesignPatternsPractice.StrategyPattern
{
    partial class StrategyContext
    {
        public class ConcreteStrategyC : IStrategy
        {
            public void AlgorithmInterface()
            {
                Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
            }
        }
    }
}
