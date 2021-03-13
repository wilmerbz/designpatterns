using AdapterPatternTest.Payment;
using AdapterPatternTest.Payment.VendorPaymentProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var paymentInfo = new PaymentInfo()
            {
                InvoiceNumber = Guid.NewGuid().ToString(),
                Ammount = random.Next(100, 10000)
            };

            var myPaymentProcessor = new MyPaymentProcessor();
            bool paymentCompleted = PaymentService.ProcessPayment(myPaymentProcessor, paymentInfo);
            if (paymentCompleted)
            {
                Console.WriteLine("Payment Processed!");
            }

            var vendorPaymentProcessorAdaptee = new VendorPaymentProcessorAdaptee();//Toma pared
            var vendorPaymentProcessorAdapter = new VendorPaymentAdapter(vendorPaymentProcessorAdaptee);//Adaptador
            paymentCompleted = PaymentService.ProcessPayment(vendorPaymentProcessorAdapter, paymentInfo);//Cable conector
            if (paymentCompleted)
            {
                Console.WriteLine("Vendor Payment Processed!");
            }

            Console.ReadKey();

        }

    }
}
