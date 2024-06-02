using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class Order
    {
        public Order(List<CartItem> cartItems, int orderId, int userId, OrderStatus orderStatus)
        {
            CartItems = cartItems;
            OrderId = orderId;
            UserId = userId;
            OrderStatus = orderStatus;
        }

        public List<CartItem> CartItems { get; init; }
        public int OrderId { get; init; }
        public int UserId { get; init; }
        public OrderStatus OrderStatus { get; init; }


    }
}
