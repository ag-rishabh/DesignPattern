using ParkingLot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.TicketUtils
{
    public class TicketGenerator
    {
        public Ticket GenerateTicket(Vehicle vehicle, ParkingSpot parkingSpot)
        {
            string ticketNumber = GetUniqueNumber();

            //logic to check is spot is free and then block the spot

            return new Ticket(ticketNumber, vehicle, parkingSpot);
        }

        private string GetUniqueNumber()
        {
            return "";
        }
    }
}
