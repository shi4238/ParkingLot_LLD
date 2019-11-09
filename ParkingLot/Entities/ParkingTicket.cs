using ParkingLot.Utils;
using System;

namespace ParkingLot.Entities
{
    class ParkingTicket
    {
        private readonly Guid id;
        private readonly DateTime entryTime;
        private readonly Vehicle vehicle;
        private int ticketAmount;

        public ParkingTicket(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            id = ParkingUtil.CreateParkingTicketId();
            entryTime = DateTime.Now;
        }

        public int GetTicketAmount() 
        {
            var vehicleType = vehicle.GetVehicleType();
        }
    }
}
