using AM.ApplicationCore;

namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Plane plane = new Plane();
            /*Plane plane2 = new Plane(PlaneType.Airbus,180,DateTime.Now);
            System.Console.WriteLine(plane2);*/
            ApplicationCore.Plane plane = new Plane()
            {
                MyPlaneType = PlaneType.Airbus,
                Capacity = 180,
                ManufactureDate = DateTime.Now
            };
            System.Console.WriteLine(plane);

        }
    }
}