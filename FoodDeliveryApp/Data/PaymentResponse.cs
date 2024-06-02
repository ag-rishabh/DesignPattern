using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class PaymentResponse
    {
        public double Amount { get; init; }
        public int Id { get; init; }
        public PaymentStatus Status { get; init; }

        public PaymentResponse(double amount, int id, PaymentStatus status)
        {
            Amount = amount;
            Id = id;
            Status = status;
        }
    }
}
