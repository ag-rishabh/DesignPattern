using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public class OrderManager
    {
        public Order PlaceOrder(User user)
        {
            CartManager cartManager = new CartManager();
            List<CartItem> cartItems = cartManager.GetUserCart(user);
            //create order in db
            return null;
        }
    }
}
