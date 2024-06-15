using ParkingLot.Data;
using ParkingLot.Enum;
using ParkingLot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.API
{
    public class PayParkingFeeApi
    {
        public bool PayParkingFee(Ticket ticket, PaymentMode paymentMode, Dictionary<string, string> paymentDetails)
        {
            IPaymentProcessor paymentProcessor = null;
            double amount = double.Parse(paymentDetails["amount"]);
            if (paymentMode == PaymentMode.CARD) 
            {
                paymentProcessor = PaymentProcessorFactory.GetCardBasedPaymentProcessor(amount, null);
            } 
            else
            {
                paymentProcessor = PaymentProcessorFactory.GetCashBasedPaymentProcessor(amount);
            }

            return new ParkingFreeProcessorService().ProcessParkingFee(ticket, paymentProcessor);
        }
    }
}
