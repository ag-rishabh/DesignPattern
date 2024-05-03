using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class Cafelatte : Coffee
    {
        public Cafelatte(IIngredientFactory ingredientFactory) : base(ingredientFactory.GetBean(), ingredientFactory.GetSuger(), ingredientFactory.GetMilk())
        {
        }

        public override void Boil()
        {
            Console.WriteLine("Boilling Cafelatte.");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing Cafelatte.");
        }
    }
}
