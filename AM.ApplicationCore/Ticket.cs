using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Ticket
    {
        [Key, ForeignKey("Passenger")]
        public int PassengerFK { get; set; }
        [Key, ForeignKey("Flight")]
        public int FlightFK { get; set; }
        public double Prix { get; set; }
        public string Siege { get; set; }
        public bool VIP { get; set; }
        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }



    }
}
