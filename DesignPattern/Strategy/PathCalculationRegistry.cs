using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class PathCalculationRegistry
    {

        private Dictionary<TransportMode, IPathCalculation> registry = new Dictionary<TransportMode, IPathCalculation>();


        public void Register(TransportMode transportMode, IPathCalculation pathCalculation)
        {
            registry[transportMode] = pathCalculation;
        }

        public IPathCalculation Get(TransportMode mode) 
        {
            return registry[mode];
        }
    }
}
