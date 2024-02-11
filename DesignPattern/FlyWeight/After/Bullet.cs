using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FlyWeight.After
{
    public class Bullet
    {
        public double Radius { get;  private set; }

        public double Weight { get; private set; }

        public ButtelType ButtelType { get; private set;}

        public String ImageURL { get; private set; }
    }
}
