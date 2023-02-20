using AM.ApplicationCore.Infterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
        public List<Flight> Flights { get; set;} = new List<Flight>();

        public ServiceFlight() {
            FlightDetailsDel = ShowFlightDetails;
            DurationAverageDel = DurationAverage;
        }

        /*List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination == destination)
                {
                    result.Add(flight.FlightDate);
                }
            }
            return result;
        }*/

        /*IEnumerable<DateTime> GetFlightDates(string destination)
        {
            for (int i = 0; i < Flights.Count; i++)
            {
                Flight flight = Flights[i];
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;
                }
            }
        }*/

        /*IEnumerable<DateTime> GetFlightDates(string destination)
        {
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;
                }
            }
        }*/

        public IList<DateTime> GetFlightDates(string destination)
        {
            return Flights.Where(f=>f.Destination == destination).Select(f=>f.FlightDate).ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var result = from f in plane.Flights
                         select new
                         {
                             Destination = f.Destination,
                             FlightDate = f.FlightDate
                         };
            foreach (var obj in result)
            {
                Console.WriteLine(obj.FlightDate + " : " + obj.Destination);
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            return Flights.Where(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7)).Count();
        }

        public double DurationAverage(string destination)
        {
            return Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();
        }

        public IList<Flight> OrderedDurationFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration).ToList();
        }

        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            return flight.Passengers.OfType<Traveller>().OrderBy(p=>p.BirthDate).Take(3).ToList<Traveller>();
        }

        public void DestinationGroupedFlights()
        {
            var result = from f in Flights group f by f.Destination;
            foreach (var group in result)
            {
                Console.WriteLine("Destination: "+group.Key+ "\n");
                foreach (var f in group)
                {
                    Console.WriteLine("Decollage: "+f.FlightDate+"\n");
                }
            }
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    {
                        var result = Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":
                    {
                        var result = Flights.Where(f => f.FlightId == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArrival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    {
                        var result = Flights.Where(f => f.EstimatedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }
        }
    }
}
