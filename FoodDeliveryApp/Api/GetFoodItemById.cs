using FoodDeliveryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Api
{
    public class GetFoodItemById
    {
        public FoodItem GetFoodItemId(int id)
        {
            return new FoodDeliveryApp.Searchers.FoodItemSearcher().SearchbyId(id);
        }
    }
}
