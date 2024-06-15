using ParkingLot.Data;

namespace ParkingLot.Services
{
    public interface VehicleTypeServices
    {
        List<ParkingSpot> GetParkingSpots();

        double GetParkingFees(double durationInHours);
    }
}
