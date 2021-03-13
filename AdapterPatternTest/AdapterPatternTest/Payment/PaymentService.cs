using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment
{
    public static class PaymentService
    {

        public static bool ProcessPayment(IPaymentProcessor paymentProcessor, PaymentInfo paymentInfo)
        {
            Console.WriteLine("Processing payment...");
            return paymentProcessor.ProcessPayment(paymentInfo);
        }

    }
}
