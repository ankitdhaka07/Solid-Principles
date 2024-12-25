using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP
{
 
    public class GenerateTextReport
    {
        public Employee1 employee;
        public string text;
        public GenerateTextReport(Employee1 employee)
        {
            this.employee = employee;
            
        }
        public void ShowTextReport()
        {
            Console.WriteLine($"Employee Report: \nName: {employee.Name}, Salary: {employee.Salary}");
        }
    }
    public class GenerateCsvReport
    {
        public Employee1 employee;
        public string text;
        public GenerateCsvReport(Employee1 employee)
        {
            this.employee = employee;
        }
        public void ShowCsvReport()
        {
            Console.WriteLine($"{employee.Name},{employee.Salary}");
        }
    }
    public class GenerateJsonReport
    {
        public Employee1 employee;
        public string text;
        public GenerateJsonReport(Employee1 employee)
        {
            this.employee = employee;
        }
        public void ShowJsonReport()
        {
            Console.WriteLine($"{{\"Name\":\"{employee.Name}\", \"Salary\":{employee.Salary}}} ");
        }
    }
}
