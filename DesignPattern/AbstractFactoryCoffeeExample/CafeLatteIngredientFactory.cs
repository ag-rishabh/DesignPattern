using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public class CafeLatteIngredientFactory : IIngredientFactory
    {
        public IBean GetBean() => new AmericanBean();

        public IMilk GetMilk() => new PowderMilk();

        public ISuger GetSuger() => new WhiteSuger();
    }
}
