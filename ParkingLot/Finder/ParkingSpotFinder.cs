using ParkingLot.Data;
using ParkingLot.Searcher;
using ParkingLot.Services;

namespace ParkingLot.Finder
{
    public class ParkingSpotFinder
    {
        private readonly VehicleTypeServices vehicleTypeServices;
        private readonly IParkingSpotSearcher parkingSpotSearcher;

        public ParkingSpotFinder(VehicleTypeServices vehicleTypeServices, IParkingSpotSearcher parkingSpotSearcher)
        {
            this.vehicleTypeServices = vehicleTypeServices;
            this.parkingSpotSearcher = parkingSpotSearcher;
        }

        public ParkingSpot FindParkingSpot()
        {
            List<ParkingSpot> parkingSpots = vehicleTypeServices.GetParkingSpots();
            return parkingSpotSearcher.SelectSpot(parkingSpots);
        }
    }
}
