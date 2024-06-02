using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public static class PaymentManagerFactory
    {
        public static IPaymentManager GetPaymentManager(string paymentMode, Dictionary<string, string> paymentInfo)
        {
            IPaymentManager paymentManager = null;

            if (paymentMode == "NetBanking")
            {
                paymentManager = GetNetBankingPaymentManager(paymentInfo);
            }
            else
            {
                paymentManager = GetCardBasedPaymentManager(paymentInfo);
            }

            return paymentManager;
        }

        private static IPaymentManager GetNetBankingPaymentManager(Dictionary<string, string> paymentInfo)
        {
            return new NetbankingManager(paymentInfo["bankname"], paymentInfo["username"], paymentInfo["password"], int.Parse(paymentInfo["amount"]), int.Parse(paymentInfo["pin"]));
        }

        private static IPaymentManager GetCardBasedPaymentManager(Dictionary<string, string> paymentInfo)
        {
            return new CardBasedPaymentManager(paymentInfo["bankname"], paymentInfo["cardnumber"], int.Parse(paymentInfo["pin"]), int.Parse(paymentInfo["amount"]));
        }
    }
}
