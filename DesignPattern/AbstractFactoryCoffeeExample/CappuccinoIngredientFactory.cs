using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class CappuccinoIngredientFactory : IIngredientFactory
    {
        public IBean GetBean() => new AmericanBean();

        public IMilk GetMilk() => new RegularMilk();

        public ISuger GetSuger() => new WhiteSuger();
    }
}
