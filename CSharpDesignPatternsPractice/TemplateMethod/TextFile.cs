using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.TemplateMethod
{
    public class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }

        //Let assume SaveData algoritum is the same in Excel and Text too
        //public void SaveData()
        //{
        //    Console.WriteLine("Saves data to Db");
        //}
    }
}
