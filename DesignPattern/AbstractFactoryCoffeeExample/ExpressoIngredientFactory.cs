using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class ExpressoIngredientFactory : IIngredientFactory
    {
        public IBean GetBean() => new FrenchBean();

        public IMilk GetMilk() => new RegularMilk();

        public ISuger GetSuger() => new BrownSuger();
    }
}
