using FoodDeliveryApp.Data;
using FoodDeliveryApp.Managers;
using FoodDeliveryApp.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class AddToCartApi
    {
        private readonly UserManager _userManager;
        private readonly FoodDeliveryApp.Searchers.FoodItemSearcher _foodItemSearcher;
        private readonly CartManager _cartManager;


        public AddToCartApi(UserManager userManager, FoodDeliveryApp.Searchers.FoodItemSearcher foodItemSearcher, CartManager cartManager)
        {
            _userManager = userManager;
            _foodItemSearcher = foodItemSearcher;
            _cartManager = cartManager;
        }

        public void AddToCart(string userToken, int foodItemId)
        {
            if(userToken == null || userToken.Length == 0 ||  foodItemId < 0)
            {
                //return Argurment exception
            }

            User user = _userManager.GetUserByToken(userToken);
            if (user == null)
            { //throw exception } 
            }

            FoodItem foodItem = _foodItemSearcher.SearchbyId(foodItemId);
            if (foodItem == null)
            { 
            }

            _cartManager.AddToCart(user, foodItem);
        }
    }
}
