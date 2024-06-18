using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public abstract class Pizza
    {
        public virtual string Name { get; init; }

        public virtual double Cost {  get; init; }

        public Pizza(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
