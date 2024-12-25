using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.AfterRefactoring
{
    public class MaintenanceService : IMaintenanceService
    {
        public void Maintenance()
        {
            Console.WriteLine("Maintenance started with DI") ;
        }
    }
}
