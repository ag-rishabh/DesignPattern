using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class PayUClient
    {
        public int PayViaCreditCard(int cardNumber, int cvv)
        {
            return 1234;
        }

        public ProcessingStatus GetProcessingStatus(int transactionId) => ProcessingStatus.Completed;
    }
}
