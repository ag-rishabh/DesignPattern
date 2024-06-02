using FoodDeliveryApp.Data;

namespace FoodDeliveryApp.Filters
{
    public interface IRestaurantFilter
    {
        bool Filter(Restaurant restaurant);
    }
}
