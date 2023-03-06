using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(int capacity, DateTime manufactureDate, PlaneType planetype)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planetype;
        }

        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneKey { get; set; }
        public PlaneType PlaneType { get; set; }

        public List<Flight>? Flights { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}