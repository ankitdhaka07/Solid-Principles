using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple.AfterRefactoring
{
    public class Human: IWorker, IWorker_HumanSpec
    {

        public int BatchId { get; set; }

        public void Schedule()
        {
            Console.WriteLine("Scheduled for worker : 8 A.M. - 6P.M.");
        }

        public void Wages()
        {
            Console.WriteLine("Wages- 300$");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
