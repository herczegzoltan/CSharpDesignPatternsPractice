using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Factory
{
    //Basic rule always program to an interface
    public interface ICalculate
    {
        void Calculate(double num1, double num2);
    }
}
