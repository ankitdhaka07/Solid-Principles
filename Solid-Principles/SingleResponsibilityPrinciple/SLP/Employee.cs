

namespace SRP
{
    public class Employee
    {
        //This emplyee class two jobs
        //1.sets and gets the basic properties of the Employee
        //2. GeneratesResports for the employee in different formats
        // one class should do only one job thus SRP is broken here 
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Method to generate a report in Text format
        public string GenerateTextReport()
        {
            return $"Employee Report: \nName: {Name}, Salary: {Salary}";
        }

        // Method to generate a report in CSV format
        public string GenerateCsvReport()
        {
            return $"{Name},{Salary}";
        }

        // Method to generate a report in JSON format
        public string GenerateJsonReport()
        {
            return $"{{\"Name\":\"{Name}\", \"Salary\":{Salary}}}";
        }
    }
}