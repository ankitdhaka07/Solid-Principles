// See https://aka.ms/new-console-template for more information
using System;

namespace SRP
{
    public class Tester
    {

        public static void Main(string[] args)
        {
            Employee emp = new Employee("old", 20000);
            Console.WriteLine("writing from Employee Class which breaks SRP");

            Console.WriteLine("emp.GenerateCsvReport() -- "+emp.GenerateCsvReport());
            Console.WriteLine("emp.GenerateTextReport() -- " + emp.GenerateTextReport());
            Console.WriteLine("emp.GenerateJsonReport() -- " + emp.GenerateJsonReport());

            Employee1 emp1 = new Employee1("new", 80000);
            Console.WriteLine("writing from Employee1 Class and GenerateReports classes which follow SRP");
            GenerateCsvReport genCsv = new GenerateCsvReport(emp1);
            GenerateTextReport genText = new GenerateTextReport(emp1);
            GenerateJsonReport genJson = new GenerateJsonReport(emp1);

            Console.WriteLine("GenerateCsvReport(emp1 ) -- ");  genCsv.ShowCsvReport();
            Console.WriteLine("GenerateTextReport(emp1 ) -- "); genText.ShowTextReport();
            Console.WriteLine("GenerateJsonReport(wmp1 ) -- ");  genJson.ShowJsonReport();



        }

    }
}