using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class GetRestaurantById
    {
        public Restaurant GetRestaurantId(int id)
        {
            return new FoodDeliveryApp.Searchers.RestaurantSearcher().SearchById(id);
        }
    }
}
