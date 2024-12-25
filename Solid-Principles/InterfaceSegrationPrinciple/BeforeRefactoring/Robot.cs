using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple.BeforeRefactoring
{
    public class Robot : IWorker
    {
        public int BatchId { get; set; }

        public void Schedule()
        {
            Console.WriteLine("Scheduled for Robot Worker: 6A.M.-11P.M. ( 5 breaks for cooling )");
        }

        public void Wages()
        {
            Console.WriteLine("Even though robot workers dont need wages still have to implement Wages() reqd for implementing interface IWorker");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Even though robot workers dont eat still have to implement Eat() reqd for implementing interface IWorker");
        }
    }
}
