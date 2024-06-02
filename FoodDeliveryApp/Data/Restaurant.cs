using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Data
{
    public class Restaurant
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public BusinessHours BusinessHours { get; init; }
        public MealType MealType { get; init; }
        public List<CuisineType> Cuisines { get; init; }
        public StarRating StarRating { get; init; }
        public Menu Menu { get; init; }
        public Address Address { get; init; }

        public Restaurant(int id, string name, string description, BusinessHours businessHours, MealType mealType, List<CuisineType> cuisines, StarRating starRating, Menu menu, Address address)
        {
            Id = id;
            Name = name;
            Description = description;
            BusinessHours = businessHours;
            MealType = mealType;
            Cuisines = cuisines;
            StarRating = starRating;
            Menu = menu;
            Address = address;
        }
    }
}
