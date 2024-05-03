using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryCoffeeExample
{
    public abstract class Coffee
    {
        public IBean Bean { get; private set; }

        public ISuger Suger { get; private set; }

        public IMilk Milk { get; private set; }

        public Coffee(IBean bean, ISuger suger, IMilk milk)
        {
            Bean = bean;
            Suger = suger;
            Milk = milk;
        }

        public abstract void Brew();

        public abstract void Boil();
    }
}
