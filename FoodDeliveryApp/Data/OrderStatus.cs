using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public enum OrderStatus
    {
        ORDER_PLACED,
        ORDER_ACCEPTED,
        COOKING,
        READY_FOR_DELIVERY,
        OUT_FOR_DELIVERY,
        DELIVERED,
        CANCELED
    }
}
