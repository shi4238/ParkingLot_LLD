using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Utils
{
    static class VehicleUtil
    {
        private static int newVehicleId = 0;

        public static int CreateVehicleId() 
        {
            newVehicleId++;
            return newVehicleId;
        }

    }
}
