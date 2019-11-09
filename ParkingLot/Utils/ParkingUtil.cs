using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Utils
{
    static class ParkingUtil
    {
        public static Guid CreateParkingTicketId() 
        {
            return Guid.NewGuid();
        }
    }
}
