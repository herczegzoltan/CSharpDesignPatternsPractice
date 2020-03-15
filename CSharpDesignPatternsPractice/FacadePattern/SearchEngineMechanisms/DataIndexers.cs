using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.FacadePattern.SearchEngineMechanisms
{
    public class DataIndexers
    {
        public int[] GetIndexersOfStoredData(string query)
        {
            Console.WriteLine($"{query} can be found at index: 1, 5, 8");
            return new[] { 1, 5, 8 };
        }
    }
}
