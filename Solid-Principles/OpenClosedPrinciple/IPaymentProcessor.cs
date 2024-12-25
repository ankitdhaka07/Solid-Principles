using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public interface IPaymentProcessor
    {
        public void ProcessPayment(double amount);
    }
}
