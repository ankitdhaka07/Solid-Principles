using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple.BeforeRefactoring
{
    public interface IWorker
    {
        public void Work();
        public void Schedule();
        public void Wages();
        public int BatchId { get; set; }

        public void Eat();
    }
}
