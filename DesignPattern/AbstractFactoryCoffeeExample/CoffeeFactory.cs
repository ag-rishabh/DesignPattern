using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class CoffeeFactory
    {
        public static Coffee GetCoffee(CoffeeType coffeeType)
        {
            Coffee coffee = null;

            if(coffeeType == CoffeeType.Cafelatte)
            {
                coffee = new Cafelatte(new CafeLatteIngredientFactory());
            }
            else if(coffeeType == CoffeeType.Expresso)
            {
                coffee = new Expresso(new ExpressoIngredientFactory());
            }
            else if(coffeeType == CoffeeType.Cappuccino)
            {
                coffee = new Cappuccino(new CappuccinoIngredientFactory());
            }

            return coffee;
        }
    }
}
