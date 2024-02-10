using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public interface IPaymentGateway
    {
        int PayViaCreditCard(int cardNumber, int cvv, string expirydate, int amount);

        ProcessingStatus GetPaymentStatus(int paymentId);
    }
}
