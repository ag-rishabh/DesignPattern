using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public interface IIngredientFactory
    {
        IBean GetBean();

        ISuger GetSuger();

        IMilk GetMilk();
    }
}
