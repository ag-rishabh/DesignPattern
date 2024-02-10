using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class RazorpayAdaptor : IPaymentGateway
    {
        private RazorpayClient razorpayClient = new RazorpayClient();

        public ProcessingStatus GetPaymentStatus(int paymentId)
        {
            return razorpayClient.GetProcessingStatus(paymentId);
        }

        public int PayViaCreditCard(int cardNumber, int cvv, string expirydate, int amount)
        {
            return razorpayClient.PayByCreditCard(cardNumber, cvv, expirydate);
        }
    }
}
