using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class WalkPathCalculation : IPathCalculation
    {
        public void CalculatePath(string from, string to)
        {
            Console.WriteLine("Walk Path Calculation Alogorithm");
        }
    }
}
