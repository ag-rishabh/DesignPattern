using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Filters
{
    public class CusiniesTypeFilter : IFoodItemFilter, IRestaurantFilter
    {
        private readonly List<CuisineType> _cuisines;

        public CusiniesTypeFilter(List<CuisineType> cuisineTypes)
        {
            _cuisines = cuisineTypes;
        }

        public bool Filter(FoodItem item)
        {
            return _cuisines.Any(c => c == item.CuisineType);
        }

        public bool Filter(Restaurant restaurant)
        {
            return _cuisines.Any(c => restaurant.Cuisines.Contains(c));
        }
    }
}
