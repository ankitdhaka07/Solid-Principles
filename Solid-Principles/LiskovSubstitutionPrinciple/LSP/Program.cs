
using LSP.AfterRefactoring;
using LSP.BeforeRefactoring;

namespace LSP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //LiskovSubstitutionPrinciple
            //objects of a childClasses shall be replaceable with objects of its parentclasses without breaking the application.

            // Initially Fly was method of base class Bird ... After Refactoring we move this method to IFly interface so that all flying birds can implement it & base 
            // class can be inherited by all birds

            //Before Refactoring

            BeforeRefactoring.Bird peng1 = new BeforeRefactoring.Penguin();
            peng1.Fly();
            BeforeRefactoring.Bird sparow1= new BeforeRefactoring.Sparrow();
            sparow1.Fly();

            //After Refactoring

            AfterRefactoring.Bird peng2 = new AfterRefactoring.Penguin();            
            peng2.Walk();

            IFly sparow2 = new AfterRefactoring.Sparrow();
            sparow2.Fly();

        }


    }
}
