using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.AfterRefactoring
{
    public class GowraPalladium
    {
        public IMaintenanceService maintenanceService;
        public GowraPalladium(IMaintenanceService maintenanceService) 
        { 
            this.maintenanceService = maintenanceService;
        }
        
        public void maintain() 
        {
            maintenanceService.Maintenance();
        }
    
    }
}
