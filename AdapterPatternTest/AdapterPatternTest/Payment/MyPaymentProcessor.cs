using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment
{
    public class MyPaymentProcessor : IPaymentProcessor
    {
        private Dictionary<string, decimal> _payments = new Dictionary<string, decimal>();
        public bool ProcessPayment(PaymentInfo paymentInfo)
        {
            var result = false;

            if (!_payments.ContainsKey(paymentInfo.InvoiceNumber))
            {
                _payments.Add(paymentInfo.InvoiceNumber, paymentInfo.Ammount);
                result = true;
                Console.WriteLine("Payment processed by MyPaymentProcessor.");
            }

            return result;
        }
    }
}
