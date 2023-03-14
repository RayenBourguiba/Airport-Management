using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int SeatFK { get; set; }
        public string PassengerFK { get; set; }
    }
}
