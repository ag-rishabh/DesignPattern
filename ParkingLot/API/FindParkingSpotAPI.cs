using ParkingLot.Data;
using ParkingLot.Enum;
using ParkingLot.Finder;
using ParkingLot.Searcher;
using ParkingLot.Services;

namespace ParkingLot.API
{
    public class FindParkingSpotAPI
    {
        public ParkingSpot FindParkingSpot(EntryPoint entryPoint, VehicleType vechicleType, SpotSelection spotSelection)
        {
            VehicleTypeServices vehicleTypeServices = VehicleTypeServicesFactory.GetVehicleTypeService(vechicleType);

            IParkingSpotSearcher parkingSpotSearcher = null;

            if (spotSelection == SpotSelection.RANDOM)
            {
                parkingSpotSearcher = SpotSelectionFactory.GetRandomSelector();
            }
            else
            {
                parkingSpotSearcher = SpotSelectionFactory.GetNearestSelector(entryPoint);
            }

            ParkingSpotFinder finder = new ParkingSpotFinder(vehicleTypeServices, parkingSpotSearcher);
            return finder.FindParkingSpot();
        } 
    }
}
