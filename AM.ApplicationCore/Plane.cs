using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public ICollection<Flight> Flights { get; set;}

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            Capacity = capacity;
            ManufactureDate = date;
            MyPlaneType = pt;
        }

        public Plane() { }


        public override string ToString()
        {
            return "Capacity:" + Capacity +
                            ", ManufactureDate: " + ManufactureDate +
                            ", PlaneId: " + PlaneId +
                            ", Plane Type: " + MyPlaneType;
        }


    }
}
