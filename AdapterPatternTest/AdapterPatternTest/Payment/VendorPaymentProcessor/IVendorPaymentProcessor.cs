using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment.VendorPaymentProcessor
{
    public interface IVendorPaymentProcessor
    {

        string ProcessVendorPayment(string invoiceID, decimal ammount);

    }
}
