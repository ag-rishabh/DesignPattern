using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class BusPathCalculation : IPathCalculation
    {
        public void CalculatePath(string from, string to)
        {
            Console.WriteLine("Bus Path Calculation Algorithm");
        }
    }
}
