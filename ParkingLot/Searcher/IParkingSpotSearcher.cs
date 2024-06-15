using ParkingLot.Data;

namespace ParkingLot.Searcher
{
    public interface IParkingSpotSearcher
    {
        ParkingSpot SelectSpot(List<ParkingSpot> parkingSpots);
    }
}
