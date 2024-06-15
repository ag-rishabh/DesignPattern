using ParkingLot.Enum;

namespace ParkingLot.Services
{
    public class VehicleTypeServicesFactory
    {
        public static VehicleTypeServices GetVehicleTypeService(VehicleType vehicleType)
        {
            VehicleTypeServices services = null;

            if(vehicleType == VehicleType.TWO_WHEELER)
            {
                services = new TwoWheelerServies();
            }
            else if(vehicleType == VehicleType.FOUR_WHEELER)
            {
                services = new FourWheelerServices();
            }
            else
            {
                services = new HeavyVehicleServices();
            }

            return services;
        }
    }
}
