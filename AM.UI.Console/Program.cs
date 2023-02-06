using AM.ApplicationCore;
using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;

namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Plane plane = new Plane();
            plane.Capacity = 100;
            plane.ManufactureDate = DateTime.Now;
            Plane plane2 = new Plane(PlaneType.Airbus,180,DateTime.Now);
            System.Console.WriteLine(plane2);*/
            /*Plane plane = new Plane()
            {
                MyPlaneType = PlaneType.Airbus,
                Capacity = 180,
                ManufactureDate = DateTime.Now
            };
            System.Console.WriteLine(plane);*/

            /*Passenger p= new Passenger();
            Staff s = new Staff();
            Traveller tr = new Traveller();

            System.Console.WriteLine(p.GetPassengerType());
            System.Console.WriteLine(s.GetPassengerType());
            System.Console.WriteLine(tr.GetPassengerType());*/

            /*ArrayList list= new ArrayList();
            list.Add(10);
            list.Add("ABC");
            list.Add('t');

            for (int i = 0; i < list.Count ; i++)
            {
                System.Console.WriteLine(list[i]);
            }


            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            List<Passenger> list2= new List<Passenger>();
            list2.Add(new Passenger() { BirthDate = DateTime.Now, FirstName="Foulen",LastName="Fouleni" });

            List<Passenger> list3= new List<Passenger>()
            {
                new () {BirthDate = DateTime.Now, FirstName="Foulen",LastName="Fouleni"},
                new Passenger() {BirthDate = DateTime.Now, FirstName="Foulen2",LastName="Fouleni2"}
            };

            List<Traveller> list4= new List<Traveller>()
            {
                new () {BirthDate = DateTime.Now, Nationality="TN"}
            };
            List<Staff> list5= new List<Staff>()
            {
                new () {BirthDate = DateTime.Now, PasseportNumber="78946413TN"}
            };

            //list3.AddRange(list4);

            list3 = new List<Passenger>(list4);*/

            ServiceFlight serviceFlight = new ServiceFlight();

            serviceFlight.Flights = TestData.Flights;



        }
    }
}