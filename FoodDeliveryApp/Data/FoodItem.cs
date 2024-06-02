using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class FoodItem
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public double PriceINR { get; init; }
        public MealType MealType { get; init; }
        public CuisineType CuisineType { get; init; }
        public StarRating StarRating { get; init; }
        public int RestaurantId { get; init; }
        public bool IsAvailable { get; init; }

        public FoodItem(int iD, string name, string description, double priceINR, MealType mealType, CuisineType cuisineType, StarRating starRating, int restaurantId, bool isAvailable)
        {
            ID = iD;
            Name = name;
            Description = description;
            PriceINR = priceINR;
            MealType = mealType;
            CuisineType = cuisineType;
            StarRating = starRating;
            RestaurantId = restaurantId;
            IsAvailable = isAvailable;
        }
    }
}
