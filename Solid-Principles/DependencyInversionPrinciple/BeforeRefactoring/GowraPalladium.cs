using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.BeforeRefactoring
{
    public class GowraPalladium
    {
        private MaintenanceService maintainer;
        public GowraPalladium() 
        {
            maintainer = new MaintenanceService();
        }
        public void maintain()
        {
            maintainer.Maintenance();
        }
    }
}
