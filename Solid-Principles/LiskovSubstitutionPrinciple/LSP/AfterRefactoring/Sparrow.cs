using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.AfterRefactoring
{
    public class Sparrow : Bird, IFly 
    {
        public  void Fly()
        {
            Console.WriteLine("Sparrow Flies");
        }
    }
}
