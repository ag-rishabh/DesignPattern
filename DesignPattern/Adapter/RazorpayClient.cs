using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class RazorpayClient
    {
        public int PayByCreditCard(int cardNumber, int cvv, string dateofExpiry)
        {
            // returns transaction id
            return 123;
        }

        public ProcessingStatus GetProcessingStatus(int transactionId)
        {
            return ProcessingStatus.Running;
        }
    }
}
