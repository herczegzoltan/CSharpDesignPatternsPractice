using System;

namespace CSharpDesignPatternsPractice.Singleton
{
    class TestLogger
    {
        static void Main()
        {
            Logger ob1 = Logger.Instance;
            
            Logger ob2 = Logger.Instance;


            //Same hashcode
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());
        }
    }
}
