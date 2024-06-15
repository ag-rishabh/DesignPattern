using ParkingLot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    public class CardPaymentProcessor : IPaymentProcessor
    {
        private readonly double _amount;
        private readonly CardDetails _cardDetails;

        public CardPaymentProcessor(double amount, CardDetails cardDetails)
        {
            _amount = amount;
            _cardDetails = cardDetails;
        }

        public bool ExecutePayment()
        {
            throw new NotImplementedException();
        }
    }
}
