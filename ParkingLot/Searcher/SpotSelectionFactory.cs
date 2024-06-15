using ParkingLot.Data;

namespace ParkingLot.Searcher
{
    public class SpotSelectionFactory
    {
        public static IParkingSpotSearcher GetNearestSelector(EntryPoint entryPoint)
        {
            return new NearestSelector(entryPoint);
        }

        public static IParkingSpotSearcher GetRandomSelector()
        {
            return new RandomSelector();
        }
    }
}
