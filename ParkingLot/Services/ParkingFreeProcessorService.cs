using ParkingLot.Data;
using ParkingLot.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    public class ParkingFreeProcessorService
    {
        public double GetParkingFee(Ticket ticket)
        {
            double duration = 0;
            //figure out the duration
            VehicleType vehicleType = ticket.Vehicle.VehicleType;
            return VehicleTypeServicesFactory.GetVehicleTypeService(vehicleType).GetParkingFees(duration);
        }

        public bool ProcessParkingFee(Ticket ticket, IPaymentProcessor paymentProcessor) 
        {
            return paymentProcessor.ExecutePayment();
        }
    }
}
