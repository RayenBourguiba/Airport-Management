using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //[Table("Vols")]
    public class Flight
    {
        public int FlightId { get; set; }
        public String Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }


        public List<Ticket>? Tickets { get; set; }
        // [ForeignKey("PlaneId")]
        public Plane? Plane { get; set; }

        [ForeignKey("Plane")]
        public int? PlaneFk { get; set; } // prop clé etrangére
        public override string? ToString()
        {
            return base.ToString();
        }
    }





}
