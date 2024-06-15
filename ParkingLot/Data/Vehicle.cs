using ParkingLot.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data
{
    public class Vehicle
    {
        public string Name { get; init; }
        public VehicleType VehicleType { get; init; }
        public string Number { get; init; }
        public DateTime EntryTime { get; init; }

        public Vehicle(string name, VehicleType vehicleType, string number, DateTime entryTime)
        {
            Name = name;
            VehicleType = vehicleType;
            Number = number;
            EntryTime = entryTime;
        }
    }
}
