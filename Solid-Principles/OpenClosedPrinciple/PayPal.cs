using System;

namespace OpenClosePrinciple 
{
    public class PayPal : IPaymentProcessor
    {

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}.");
        }
    }
}