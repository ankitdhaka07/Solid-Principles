using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrationPrinciple.AfterRefactoring
{
    public interface IWorker
    {
        public void Work();
        public void Schedule();
        public int BatchId { get; set; }

    
    }
}
