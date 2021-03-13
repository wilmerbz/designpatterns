using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTest.Payment
{
    public interface IPaymentProcessor
    {
        bool ProcessPayment(PaymentInfo paymentInfo);
    }
}
