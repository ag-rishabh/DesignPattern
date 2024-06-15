using ParkingLot.Enum;

namespace ParkingLot.Data
{
    public class ParkingSpot
    {
        public string FloorNumber { get; init; }
        public VehicleType VehicleType { get; init; }
        public string Name { get; init; }
        public bool IsFree {  get; init; }

        public ParkingSpot(string floorNumber, VehicleType vehicleType, string name, bool isFree)
        {
            FloorNumber = floorNumber;
            VehicleType = vehicleType;
            Name = name;
            IsFree = isFree;
        }
    }
}
