using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment.VendorPaymentProcessor
{
    public class VendorPaymentProcessorAdaptee : IVendorPaymentProcessor
    {
        private Dictionary<string, decimal> _payments = new Dictionary<string, decimal>();

        public string ProcessVendorPayment(string invoiceID, decimal ammount)
        {
            var result = "";

            if (!_payments.ContainsKey(invoiceID))
            {
                _payments.Add(invoiceID, ammount);
                result = "success";
                Console.WriteLine("Vendor Payment Processed by Adaptee.");
            }
            else
            {
                result = "fail";
                Console.WriteLine("Vendor Payment Could not be Processed by Adaptee.");
            }

            return result;
        }
    }
}
