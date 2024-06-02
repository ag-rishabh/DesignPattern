using FoodDeliveryApp.Data;
using FoodDeliveryApp.Filters;
using FoodDeliveryApp.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class RestaurantSearcher
    {
        public List<Restaurant> SearchRestaurant(string restaurantName, MealType mealType, List<CuisineType> cuisineTypes, StarRating starRating)
        {
            //validate parameter

            List<IRestaurantFilter> filters = new List<IRestaurantFilter>();

            if(mealType != null)
            {
                filters.Add(new MealTypeFilter(mealType));
            }

            if(cuisineTypes != null && cuisineTypes.Count > 0)
            {
                filters.Add(new CusiniesTypeFilter(cuisineTypes));
            }

            if(starRating != null)
            {
                filters.Add(new StarRatingFilter(starRating));
            }

            List<Restaurant> restaurants = new FoodDeliveryApp.Searchers.RestaurantSearcher().Search(restaurantName, filters);
            return restaurants;
        }
    }
}
