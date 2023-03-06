using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void FullNamePassenger(this Passenger passenger)
        {
            //passenger.FirstName = passenger.FirstName[0].ToString().ToUpper() + passenger.FirstName.Substring(1);
            //passenger.LastName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);

        }


    }
}