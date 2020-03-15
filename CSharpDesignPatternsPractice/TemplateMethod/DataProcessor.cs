using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.TemplateMethod
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();

        //Let assume SaveData algoritum is the same in Excel and Text too
        public void SaveData()
        {
            Console.WriteLine("Saves data to Db");
        }
    }
}
