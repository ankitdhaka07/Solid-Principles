using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.AfterRefactoring
{
    public class Penguin: Bird
    {
        public  void Swim()
        {
            Console.WriteLine("Penguin swims ");
        }
    }
}
