using ParkingLot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    public class PaymentProcessorFactory
    {
        public static IPaymentProcessor GetCardBasedPaymentProcessor(double amount, CardDetails cardDetails)
        {
            return new CardPaymentProcessor(amount, cardDetails);
        }

        public static IPaymentProcessor GetCashBasedPaymentProcessor(double amount)
        {
            return new CashPaymentProcessor(amount);
        }
    }
}
