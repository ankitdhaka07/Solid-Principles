using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class PaymentProcessorOCP
    {
        public void ProcessPayment(IPaymentProcessor serviceProvider, double amount )
        {
            serviceProvider.ProcessPayment( amount );
        }


    }
}
