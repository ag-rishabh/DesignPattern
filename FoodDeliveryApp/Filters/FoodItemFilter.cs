using FoodDeliveryApp.Data;


namespace FoodDeliveryApp.Filters
{
    public interface IFoodItemFilter
    {
        bool Filter(FoodItem item);
    }
}
