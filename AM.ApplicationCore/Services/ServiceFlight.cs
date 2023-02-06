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
        public List<Flight> Flights { get; set;} = new List<Flight>();

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

        IEnumerable<DateTime> GetFlightDates(string destination)
        {
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    yield return flight.FlightDate;
                }
            }
        }
    }
}
