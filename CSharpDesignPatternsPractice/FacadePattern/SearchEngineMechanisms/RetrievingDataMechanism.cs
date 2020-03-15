using System;

namespace CSharpDesignPatternsPractice.FacadePattern.SearchEngineMechanisms
{
    public class RetrievingDataMechanism
    {
        public void GetData(int[] indexes)
        {
            Console.WriteLine("Downloading web with indexes:");
            foreach (var index in indexes)
            {
                Console.WriteLine(index + ", ");
            }

            Console.WriteLine();
        }
    }
}
