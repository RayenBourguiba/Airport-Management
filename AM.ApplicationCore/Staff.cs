using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public String function { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }


        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine(" I'am a Staff Memeber");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}