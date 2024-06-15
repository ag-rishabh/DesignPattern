using ParkingLot.Data;
using ParkingLot.Services;

namespace ParkingLot.API
{
    public class GetParkingFree
    {
        public double GetParkingFee(Ticket ticket)
        {
            return new ParkingFreeProcessorService().GetParkingFee(ticket);
        }
    }
}
