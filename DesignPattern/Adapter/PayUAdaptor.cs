using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class PayUAdaptor : IPaymentGateway
    {
        private readonly PayUClient _gateway = new PayUClient();

        public ProcessingStatus GetPaymentStatus(int paymentId)
        {
            return _gateway.GetProcessingStatus(paymentId);
        }

        public int PayViaCreditCard(int cardNumber, int cvv, string expirydate, int amount)
        {
            return _gateway.PayViaCreditCard(cardNumber, cvv);
        }
    }
}
