using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment.VendorPaymentProcessor
{
    public class VendorPaymentAdapter : IPaymentProcessor
    {
        private VendorPaymentProcessorAdaptee vendorPaymentProcessorAdaptee;

        public VendorPaymentAdapter(VendorPaymentProcessorAdaptee vendorPaymentProcessorAdaptee)
        {
            this.vendorPaymentProcessorAdaptee = vendorPaymentProcessorAdaptee;
        }

        public bool ProcessPayment(PaymentInfo paymentInfo)
        {
            Console.WriteLine("Payment process delegated to Vendor Payment Processor.");
            var invoiceID = paymentInfo.InvoiceNumber;
            var ammount = paymentInfo.Ammount;
            var vendorResult = this.vendorPaymentProcessorAdaptee.ProcessVendorPayment(invoiceID, ammount);
            var result = vendorResult == "success";

            return result;
        }
    }
}
