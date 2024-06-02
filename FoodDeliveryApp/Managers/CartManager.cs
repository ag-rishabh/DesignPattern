using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Managers
{
    public class CartManager
    {
        public List<CartItem> GetUserCart(User user)
        {
            //get user cart from db
            return null;
        }

        public void AddToCart(User user, FoodItem item) 
        { 
            if(IsFoodItemFromSameRestaurant(user, item) == false)
            {
                //throw exception
            } 

            //add to cart db call
        }

        public void DeleteItemFromCart(User user, FoodItem item) 
        {
            if (IsFoodItemPresentInCart(user, item) == false)
            { 
                //throw exception
            }

            //call to db to delete food item
        }

        public void CheckOutUserCart(User user) 
        {
            if (IsCartEmpty(user) == true)
            {
                // throw exceptiom
            }

            ///start processing payment and then place order
        }


        private bool IsFoodItemFromSameRestaurant(User user, FoodItem foodItem)
        {
            List<CartItem> cartItems = GetUserCart(user);

            if (cartItems.Count == 0) return true;

            if(cartItems.ElementAt(0).FoodItem.RestaurantId == foodItem.RestaurantId) return true;

            return false;
        }

        private bool IsFoodItemPresentInCart(User user, FoodItem foodItem)
        {
            List<CartItem> cartItems = GetUserCart(user);

            foreach (CartItem cartItem in cartItems) 
            {
                if(cartItem.FoodItem.ID == foodItem.ID) return true;
            }

            return false;
        }

        private bool IsCartEmpty(User user)
        {
            List<CartItem> cartItems = GetUserCart(user);
            return cartItems.Count == 0;
        }
    }
}
