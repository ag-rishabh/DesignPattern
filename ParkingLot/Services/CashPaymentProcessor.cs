using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    public class CashPaymentProcessor : IPaymentProcessor
    {
        private readonly double _amount;

        public CashPaymentProcessor(double amount)
        {
            _amount = amount;
        }

        public bool ExecutePayment()
        {
            throw new NotImplementedException();
        }
    }
}
