using ParkingLot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Searcher
{
    public class NearestSelector : IParkingSpotSearcher
    {

        private readonly EntryPoint _entryPoint;

        public NearestSelector(EntryPoint entryPoint)
        {
            _entryPoint = entryPoint;
        }

        public ParkingSpot SelectSpot(List<ParkingSpot> parkingSpots)
        {
            throw new NotImplementedException();
        }
    }
}
