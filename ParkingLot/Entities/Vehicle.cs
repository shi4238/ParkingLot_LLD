using ParkingLot.Utils;
using static ParkingLot.Constants.Enums;

namespace ParkingLot.Entities
{
    class Vehicle
    {
        private readonly int id;
        private readonly VehicleType vehicleType;

        public Vehicle(VehicleType vehicleType)
        {
            this.vehicleType = vehicleType;
            this.id = VehicleUtil.CreateVehicleId();
        }

        public VehicleType GetVehicleType() 
        {
            return this.vehicleType;
        }
    }
}
