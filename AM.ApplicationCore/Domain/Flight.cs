using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //[table("Vols")]   annotations 
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public virtual List<Ticket>? Tickets { get; set; }
       // [ForeignKey("PlaneId")]
        public virtual Plane? Plane { get; set; }// prop navigation      => nakhtaar wahda fehom 
        [ForeignKey("Plane")]
        public int? PlaneFk { get; set; } // prop clé etrangère  => nakhtar wahda fehom
        public override string ToString()
        {
            return "FlightDate: " + FlightDate + " Destination: " + Destination + " EstimatedDuration: " + EstimatedDuration;
        }

    }
}
