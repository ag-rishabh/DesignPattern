using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Filters
{
    public class MealTypeFilter : IFoodItemFilter, IRestaurantFilter
    {

        private readonly MealType _mealType;

        public MealTypeFilter(MealType mealType)
        {
            _mealType = mealType;
        }

        public bool Filter(FoodItem item)
        {
            return item.MealType == _mealType;
        }

        public bool Filter(Restaurant restaurant)
        {
            return restaurant.MealType == _mealType;
        }
    }
}
