using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Entities
{
    class Customer
    {
        private readonly Vehicle vehicle;
        private readonly ParkingTicket parkingTicket;
        private readonly int amountToPay;

        public Customer(Vehicle vehicle, ParkingTicket parkingTicket)
        {
            this.vehicle = vehicle;
            this.parkingTicket = parkingTicket;
            this.amountToPay = 0;
        }

        public void DoPayment() 
        {
            Console.WriteLine("Payment Done: {0}", this.amountToPay);
        }
    }
}
