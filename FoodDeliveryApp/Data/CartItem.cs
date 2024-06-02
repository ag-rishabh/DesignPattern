using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class CartItem
    {
        public FoodItem FoodItem { get; init; }

        public int Quantity { get; init; }

        public CartItem(FoodItem foodItem, int quantity)
        {
            FoodItem = foodItem;
            Quantity = quantity;
        }
    }
}
