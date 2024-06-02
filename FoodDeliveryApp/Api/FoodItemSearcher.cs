using FoodDeliveryApp.Data;
using FoodDeliveryApp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class FoodItemSearcher
    {
        public List<FoodItem> SearchFoodItems(string foodItemName, MealType mealType, List<CuisineType> cuisineTypes, StarRating rating)
        {
            List<IFoodItemFilter> filters = new List<IFoodItemFilter>();

            if(mealType != null)
            {
                filters.Add(new MealTypeFilter(mealType));
            }

            if(cuisineTypes != null)
            {
                filters.Add(new CusiniesTypeFilter(cuisineTypes));
            }

            if(rating != null)
            {
                filters.Add(new  StarRatingFilter(rating));
            }

            List<FoodItem> foodItems = new FoodDeliveryApp.Searchers.FoodItemSearcher().Search(foodItemName, filters);

            return foodItems;
        }
    }
}
