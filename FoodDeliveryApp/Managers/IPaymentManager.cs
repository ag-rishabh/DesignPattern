using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public interface IPaymentManager
    {
        PaymentResponse ExecutePayment();
    }
}
