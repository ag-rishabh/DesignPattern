using FoodDeliveryApp.Data;
using FoodDeliveryApp.Filters;

namespace FoodDeliveryApp.Searchers
{
    public class RestaurantSearcher
    {
        public List<Restaurant> Search(string restaurnat, List<IRestaurantFilter> filters)
        {
            //validate param

            List<Restaurant> restaurants = new List<Restaurant>();//get from DB

            foreach (IRestaurantFilter filter in filters) 
            { 
                List<Restaurant> filteredRestaurant = new List<Restaurant>();

                foreach (Restaurant restaurant in restaurants) 
                {
                    if(filter.Filter(restaurant))
                    {
                        filteredRestaurant.Add(restaurant);
                    }
                }
                restaurants = filteredRestaurant;
            }

            return restaurants;
        }

        public Restaurant SearchById(int id) 
        {

            List<Restaurant> restaurants = new List<Restaurant>();///get from DB

            return restaurants.Where(res => res.Id == id).FirstOrDefault();
        }
    }
}
