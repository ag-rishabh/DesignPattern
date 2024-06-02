using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Filters
{
    public class StarRatingFilter : IFoodItemFilter, IRestaurantFilter
    {
        private readonly StarRating _starRating;

        public StarRatingFilter(StarRating starRating)
        {
            _starRating = starRating;
        }

        public bool Filter(FoodItem item)
        {
            return item.StarRating >= _starRating;
        }

        public bool Filter(Restaurant restaurant)
        {
            return restaurant.StarRating >= _starRating;
        }
    }
}
