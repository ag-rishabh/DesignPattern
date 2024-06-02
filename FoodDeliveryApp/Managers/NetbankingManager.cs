using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public class NetbankingManager : IPaymentManager
    {
        public string BankName { get; init; }
        public string UserName { get; init; }
        public string Password { get; init; }
        public double Amount { get; init; }
        public int Pin { get; init; }

        public NetbankingManager(string bankName, string userName, string password, double amount, int pin)
        {
            BankName = bankName;
            UserName = userName;
            Password = password;
            Amount = amount;
            Pin = pin;
        }

        public PaymentResponse ExecutePayment()
        {
            return null;
        }
    }
}
