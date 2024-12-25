namespace SRP
{
    public class Employee1
    {
        //if we add another method of generating report we just add new class in GenerateReport.cs no need to modify existing classes
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee1 (string name, double salary){
            Name=name;
            Salary= salary;
        }
    }
}