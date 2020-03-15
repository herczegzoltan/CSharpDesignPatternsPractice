using CSharpDesignPatternsPractice.Adapter;
using CSharpDesignPatternsPractice.Singleton;
using CSharpDesignPatternsPractice.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.Factory
{
    class Program
    {
        static void Main()
        {
            //------------------------------Factory Pattern
            Console.WriteLine("Enter Add, subtract or divide");

            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            obj.Calculate(10, 10);

            //------------------------------Singleton
            Logger ob1 = Logger.Instance;

            Logger ob2 = Logger.Instance;
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());

            //------------------------------TemplateMethod
            ExcelFile objExcel = new ExcelFile();
            objExcel.ReadProcessAndSave();

            TextFile objText= new TextFile();
            objText.ReadProcessAndSave();

            //------------------------------Adapter
            Console.WriteLine("Setting input for DVI monitor!");
            VgaGraphicsCard vgaGraphicsCard = new VgaGraphicsCard();
            DviMonitor dviMonitor = new DviMonitor();
            VgaGraphicsCardAdapter vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());

        }
    }
}
