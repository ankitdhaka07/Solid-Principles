// See https://aka.ms/new-console-template for more information
using InterfaceSegrationPrinciple.AfterRefactoring;
using InterfaceSegrationPrinciple.BeforeRefactoring;


namespace ISP
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //The Interface Segregation Principle (ISP) is a software engineering design principle that states that code should not be forced to depend on methods it doesn't use.
            //The goal of ISP is to reduce the need for changes to software by splitting large interfaces into smaller, more specific ones

            //BeforeReafactoring
            //chitti is a robot and still has to implement the eat method as it implements the IWorker interface 
            var chitti1 = new InterfaceSegrationPrinciple.BeforeRefactoring.Robot();
            chitti1.BatchId = 101;
            chitti1.Work();
            chitti1.Schedule();
            chitti1.Eat();
            Console.WriteLine();
            Console.WriteLine();
            var rajni1= new InterfaceSegrationPrinciple.BeforeRefactoring.Human();
            rajni1.BatchId = 102;
            rajni1.Work(); 
            rajni1.Schedule();
            rajni1.Eat();

            Console.WriteLine("\nAfter Refactoring Robot doesn't has to implement Eat() & Wages()\n");
            //AfterRefactoring
            // we have divided the previous interface IWorker in IWorker and IworkerHumanSpec where all human specific methods are moved to IworkerHumanSpec
            var chitti2 = new InterfaceSegrationPrinciple.AfterRefactoring.Robot();
            chitti2.BatchId = 201;
            chitti2 .Work();
            chitti2.Schedule(); 
            Console.WriteLine();
            Console.WriteLine(); 
            var rajni2= new InterfaceSegrationPrinciple.AfterRefactoring.Human();
            rajni2.BatchId = 202;
            rajni2.Work(); rajni2.Schedule();
            rajni2 .Eat();
            
        }
    }

}