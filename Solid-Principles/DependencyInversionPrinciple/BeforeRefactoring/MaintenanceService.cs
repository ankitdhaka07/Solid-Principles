using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.BeforeRefactoring
{
    public class MaintenanceService()
    {
        public void Maintenance()
        {
            Console.WriteLine("Maintenance has been initiated");
        }
        
    }
}
