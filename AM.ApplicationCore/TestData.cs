using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class TestData
    {
        public static List<Plane> Planes 
        { 
            get 
            {
                return new List<Plane>()
                {
                    new Plane(){
                        MyPlaneType= PlaneType.Boing,
                        Capacity= 150,
                        ManufactureDate= new DateTime(2015,02,03)
                    },
                    new Plane(){
                        MyPlaneType= PlaneType.Airbus,
                        Capacity= 250,
                        ManufactureDate= new DateTime(2020,11,11)
                    }
                };
            } 
        }

        public static List<Staff> Staff
        { 
            get 
            {
                return new List<Staff>()
                {
                    new Staff()
                    {
                        FirstName="captain",
                        LastName="captain",
                        EmailAdress= "Captain.captain@gmail.com",
                        BirthDate = new DateTime(1965,01,01),
                        EmploymentDate = new DateTime(199,01,01),
                        Salary=99999
                    }
                };
                } 
        }

        public static List<Traveller> Travellers { get {
                return new List<Traveller>()
                {
                    new Traveller()
                    {
                        FirstName="Traveller1",
                        LastName="Traveller1",
                        EmailAdress="Traveller1.Traveller1@gmail.com",
                        BirthDate= new DateTime(1980,01,01),
                        HealthInformation="No Troubles",
                        Nationality="American"
                    }
                };
            } 
        }

        public static List<Flight> Flights { get
            {
                return new List<Flight>() {
                    new Flight()
                    {
                        FlightDate= new DateTime(2022,01,01,15,10,10),
                        Destination= "Paris",
                        EffectiveArrival= new DateTime(2022,01,01,17,10,10),
                        Plane = Planes[1],
                        EstimatedDuration= 110,
                        Passengers = new List<Passenger> (Travellers)
                    }
                };
            } 
        }

        

    }
}
