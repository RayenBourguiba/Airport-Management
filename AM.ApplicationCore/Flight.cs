﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        // [ForeignKey("PlaneId")]
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set;}
        public string Airline { get; set; }
        [ForeignKey("Plane")]
        public int PlaneId { get; set; }


        public override string ToString()
        {
            return "Destination:" + Destination +
                ",  \nDeparture: " + Departure +
                ",  \nFlightDate: " + FlightDate +
                ",  \nFlightId: " + FlightId +
                ",  \nEffectiveArrival: " + EffectiveArrival +
                ",  \nEstimatedDuration: " + EstimatedDuration;
        }
    }
}
