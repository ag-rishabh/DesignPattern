using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class CarPathCalculation : IPathCalculation
    {
        public void CalculatePath(string from, string to)
        {
            Console.WriteLine("Car Path Calculation Alog");
        }
    }
}
