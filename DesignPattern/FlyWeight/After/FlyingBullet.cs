using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FlyWeight.After
{
    public class FlyingBullet
    {
        public double X_Coordinate { get; set; }

        public double Y_Coordinate { get; set;}

        public double Z_Coordinate { get; set; }
        
        public double Direction { get; set; }

        public double Speed { get; set; }

        public Bullet Bullet { get; set; }
    }
}
