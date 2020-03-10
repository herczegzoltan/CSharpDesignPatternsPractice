using System;

namespace CSharpDesignPatternsPractice.Singleton
{
    class TestLogger
    {
        static void Main()
        {
            Logger ob1 = Logger.GetInstance();
            
            Logger ob2 = Logger.GetInstance();


            //Same hashcode
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());
        }
    }
}
