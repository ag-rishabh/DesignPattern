using FoodDeliveryApp.Data;
using FoodDeliveryApp.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class PlaceOrderApi
    {
        private readonly UserManager userManager;
        private readonly OrderManager orderManager;

        public PlaceOrderApi(UserManager userManager, OrderManager orderManager)
        {
            this.userManager = userManager;
            this.orderManager = orderManager;
        }

        public Order PlaceOrder(string userToken, Dictionary<string, string> paymentInfo, string paymentMode)
        {
            if(userToken ==  null || userToken.Length == 0)
            {
                throw new ArgumentException();
            }

            User user = userManager.GetUserByToken(userToken);
            if (user == null)
            {
                throw new ArgumentException();
            }

            IPaymentManager paymentManager = PaymentManagerFactory.GetPaymentManager(paymentMode, paymentInfo);
            PaymentResponse paymentResponse =  paymentManager.ExecutePayment();

            if (paymentResponse == null || paymentResponse.Status == PaymentStatus.Failed) 
            { 
                // throw exception
            }

            return orderManager.PlaceOrder(user);
        }
    }
}
