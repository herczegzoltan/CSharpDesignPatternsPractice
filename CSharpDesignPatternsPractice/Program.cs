using CSharpDesignPatternsPractice.AdapterPattern;
using CSharpDesignPatternsPractice.FacadePattern;
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
            Console.WriteLine("Factory");
            //------------------------------Factory Pattern
            Console.WriteLine("Enter Add, subtract or divide");

            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            obj.Calculate(10, 10);

            Console.WriteLine("Singleton");
            //------------------------------Singleton
            Logger ob1 = Logger.Instance;

            Logger ob2 = Logger.Instance;
            Console.WriteLine(ob1.GetHashCode());
            Console.WriteLine(ob2.GetHashCode());

            Console.WriteLine("TemplateMethod");
            //------------------------------TemplateMethod
            ExcelFile objExcel = new ExcelFile();
            objExcel.ReadProcessAndSave();

            TextFile objText= new TextFile();
            objText.ReadProcessAndSave();

            Console.WriteLine("Adapter");
            //------------------------------Adapter
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            target.GetRequest();


            Console.WriteLine("Facade");
            //------------------------------Facade
            var searchEngineFacade = new SearchEngineFacade();
            var searchingResults = searchEngineFacade.GetSearchResults("My query");
            Console.WriteLine(searchingResults);
        }
    }
}
