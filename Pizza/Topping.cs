using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public abstract class Topping : Pizza
    {
        public Pizza Pizza { get; init; }

        public Topping(string name, double cost, Pizza pizza) : base(name, cost)
        {
            Pizza = pizza;
        }
    }
}
