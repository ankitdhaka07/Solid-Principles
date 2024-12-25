using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple.AfterRefactoring
{
    public class Robot: IWorker
    {
        public int BatchId { get; set; }

        public void Schedule()
        {
            Console.WriteLine("Scheduled for Robot Worker: 6A.M.-11P.M. ( 5 breaks for cooling )");
        }


        public void Work()
        {
            Console.WriteLine("Working");
        }

    }
}