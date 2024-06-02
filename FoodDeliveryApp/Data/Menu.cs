namespace FoodDeliveryApp.Data
{
    public class Menu
    {
        public List<FoodItem> Items { get; init; }

        public Menu(List<FoodItem> items)
        {
            Items = items;
        }

    }
}