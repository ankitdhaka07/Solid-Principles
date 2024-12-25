

namespace OpenClosePrinciple
{
    public class Tester
    {

        public static void Main(string[] args)
        {
            //states that software entities (such as classes, modules, and functions) should be open for extension but closed for modification.
            //In other words, developers should be able to add new functionality to a class without changing its existing implementation.

        
            // Initialize payment methods

            // Here this paymentProcess class is having implementations for each payment method so every time there is a new payment method we have to modify PaymentProcess
          
                   
            // Initialize Payment Processor
            PaymentProcessor paymentProcessor = new PaymentProcessor();

                // Process CreditCard payment
            paymentProcessor.ProcessPayment("CreditCard", 100.50);

                // Process PayPal payment
            paymentProcessor.ProcessPayment("PayPal", 250.75);


                //we are making a new interface IPaymentProcessor that implements a method ProcessPayment and all classes should implement it
                
            PaymentProcessorOCP paymentProcessor1 = new PaymentProcessorOCP();
            IPaymentProcessor serviceProvider = new PayPal();
            paymentProcessor1.ProcessPayment(serviceProvider,34.5);
                           
            
        }
        //****************************
        //****************************




    } 




}







