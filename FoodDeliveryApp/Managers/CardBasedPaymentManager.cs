using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public class CardBasedPaymentManager : IPaymentManager
    {
        public CardBasedPaymentManager(string bankName, string cardNumber, int pin, double amount)
        {
            BankName = bankName;
            CardNumber = cardNumber;
            Pin = pin;
            Amount = amount;
        }

        public string BankName { get; init; }
        public string CardNumber { get; init; }
        public int Pin { get; init; }
        public double Amount { get; init; }

        public PaymentResponse ExecutePayment()
        {
            return null;
        }
    }
}
