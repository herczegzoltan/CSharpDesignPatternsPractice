using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;

            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }
            else
            {
                Console.WriteLine("we don't do that");
            }

            return obj;
        }
    }
}
