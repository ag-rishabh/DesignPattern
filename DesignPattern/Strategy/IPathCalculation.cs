using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public interface IPathCalculation
    {
        void CalculatePath(string from, string to);
    }
}
