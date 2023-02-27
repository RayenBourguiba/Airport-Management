using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        // [DisplayName("Date Of Birth")]
        [Display(Name = "Date Of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key, StringLength(7)]
        public string PasseportNumber { get; set; }
        // [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAdress { get;set; }
        [MinLength(3, ErrorMessage="Length must be > 3"),MaxLength(25, ErrorMessage="Length must be < 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RegularExpression("[0-9]{8}")]
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