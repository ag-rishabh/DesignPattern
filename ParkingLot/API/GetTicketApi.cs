using ParkingLot.Data;
using ParkingLot.TicketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.API
{
    public class GetTicketApi
    {
        public Ticket GetTicket(Vehicle vehicle, ParkingSpot parkingSpot)
        {
            return new TicketGenerator().GenerateTicket(vehicle, parkingSpot);
        }
    }
}
