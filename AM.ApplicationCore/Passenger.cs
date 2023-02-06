using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PasseportNumber { get; set; }
        public string EmailAdress { get;set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "BirthDate:" + BirthDate +
                            ", PassportNumber: " + PasseportNumber +
                            ", EmailAddress: " + EmailAdress +
                            ", FirstName: " + FirstName +
                            ", LastName: " + LastName +
                            ", TelNumber: " + TelNumber;
        }

        //public bool CheckProfile(string nom, string prenom) { return FirstName == prenom && LastName == nom; }

        //public bool CheckProfile(string nom, string prenom, string email) { return FirstName == prenom && LastName == nom && EmailAdress=email; }

        public bool CheckProfile(string nom, string prenom, string? email = null)
        {
            return FirstName == prenom
                && LastName == nom
                && (email == null || EmailAdress == email);
        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
    }
}