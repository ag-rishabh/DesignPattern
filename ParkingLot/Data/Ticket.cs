using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data
{
    public class Ticket
    {
        public string RefNum { get; init; }
        public Vehicle Vehicle { get; init; }
        public ParkingSpot ParkingSpot { get; init; }

        public Ticket(string refNum, Vehicle vehicle, ParkingSpot parkingSpot)
        {
            RefNum = refNum;
            Vehicle = vehicle;
            ParkingSpot = parkingSpot;
        }
    }
}
