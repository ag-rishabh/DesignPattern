using FoodDeliveryApp.Data;
using FoodDeliveryApp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Searchers
{
    public class FoodItemSearcher
    {
        public List<FoodItem> Search(string foodItemName, List<IFoodItemFilter> filters)
        {
            List<FoodItem> foodItems = new List<FoodItem>(); // get from db

            foreach (IFoodItemFilter filter in filters) 
            { 
                List<FoodItem> filteredFooditem = new List<FoodItem>();

                foreach (FoodItem foodItem in foodItems)
                {
                    if(filter.Filter(foodItem)) filteredFooditem.Add(foodItem);
                }
                foodItems = filteredFooditem;
            }

            return foodItems;
        }

        public FoodItem SearchbyId(int id) 
        {
            List<FoodItem> foodItems = new List<FoodItem>();//get from DB

            return foodItems.Where(foodItem => foodItem.ID == id).FirstOrDefault();
        }
    }
}