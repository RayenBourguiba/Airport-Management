using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Infterfaces
{
    public interface IServiceFlight
    {
        IList<DateTime> GetFlightDates(string destination);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IList<Flight> OrderedDurationFlights();
        IList<Traveller> SeniorTravellers(Flight flight);
        void DestinationGroupedFlights();
        void GetFlights(string filterType, string filterValue);

    }
}
