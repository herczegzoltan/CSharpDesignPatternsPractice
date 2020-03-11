using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Factory
{
    public class Divide : ICalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine(num1/num2);
        }
    }
}
