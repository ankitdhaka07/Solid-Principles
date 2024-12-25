using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{


        // PaymentProcessor handles all types of payments directly
        //if we want to extend to new payment method .i.e google pay.... we will have to change exisiting code meaning the code is open for modification ...i .e not suitable
         public class PaymentProcessor
        {
            public void ProcessPayment(string paymentType, double amount)
            {
                if (paymentType == "CreditCard")
                {
                    Console.WriteLine($"Processing credit card payment of {amount}.");
                }
                else if (paymentType == "PayPal")
                {
                    Console.WriteLine($"Processing PayPal payment of {amount}.");
                }
                else
                {
                    Console.WriteLine("Invalid payment method.");
                }
            }
        }

       
    }




