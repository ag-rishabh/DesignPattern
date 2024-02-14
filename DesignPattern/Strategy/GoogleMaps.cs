using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class GoogleMaps
    {
        private readonly PathCalculationRegistry _registry = new PathCalculationRegistry();

        public GoogleMaps()
        {
            _registry.Register(TransportMode.WALK, new WalkPathCalculation());
            _registry.Register(TransportMode.CAR, new CarPathCalculation());    
            _registry.Register(TransportMode.BUS, new BusPathCalculation());
        }

        public void FindPath(string from, string to, TransportMode transportMode)
        {
            IPathCalculation pathCalculation = _registry.Get(transportMode);
            pathCalculation.CalculatePath(from, to);
        }
    }
}
