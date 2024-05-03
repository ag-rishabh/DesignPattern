using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class Cappuccino : Coffee
    {

        public Cappuccino(IIngredientFactory ingredientFactory) : base(ingredientFactory.GetBean(), ingredientFactory.GetSuger(), ingredientFactory.GetMilk())
        { 
        }

        public override void Boil()
        {
            Console.WriteLine("Boilling Cappuccion.");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing Cappuccion.");
        }
    }
}
