using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class CoffeeServer
    {
        
        public static void ServerCoffe(CoffeeType coffeeType)
        {
            Coffee coffee = CoffeeFactory.GetCoffee(coffeeType);
            coffee.Brew();
            coffee.Boil();
        }
    }
}
