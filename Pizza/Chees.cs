using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Chees : Topping
    {
        public override string Name { get { return base.Name + " " + Pizza.Name; } init => base.Name = value; }

        public override double Cost { get { return  base.Cost + Pizza.Cost; } init => base.Cost = value; }

        public Chees(Pizza pizza) : base("chees", 60, pizza) { }
    }
}
