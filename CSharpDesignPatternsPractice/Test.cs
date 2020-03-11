using CSharpDesignPatternsPractice.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Factory
{
    class Test
    {
        static void Main()
        {
            //Factory Pattern
            Console.WriteLine("Enter Add, subtract or divide");

            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            obj.Calculate(10, 10);


            //Singleton
            Logger ob1 = Logger.Instance;

            Logger ob2 = Logger.Instance;
            //Same hashcode
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());
        }
    }
}
