using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Domain
{
   
    public class Passenger
    {
        public int PassengerId { get; set; }
        [Key, StringLength(7)]
        public string PassportNumber { get; set; }
        //[MinLength(3 , ErrorMessage ="doit etre > 3") ,MaxLength(25 , ErrorMessage = "doit etre < 25 ")]
        public FullName FullName { get; set; }

        [Display(Name ="Date of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
      //  [RegularExpression("[0-9]{,8}")]   virgule avant 8 yaani tanjem tekhou 0 walla 1 ..... w kif yabda virgule baaed l 8,
      // yaani tnajem tekhou au minimum 8 
        [RegularExpression("[0-9]{8}")]
        public int? TelNumber { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public virtual List<Reservation> Reservations { get; set; }

        public virtual  List<Ticket>? Tickets { get; set; }

        // methode ToString :

        //public override string ToString()
        //{
        //    return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        //}
        //Le polymorphisme par signature

        //1-

        //public bool CheckProfile(string firstName, string lastName)
        //{
        //    return FirstName == firstName && LastName == lastName;
        //}

        //2-

        //public bool CheckProfile(string firstName, string lastName, string email)
        //{
        //    return FirstName == firstName && LastName == lastName && EmailAddress == email;
        //}

        // 3- 
        //public bool login(string firstName, string lastName, string email = null)
        //{
        //    if (email != null)
        //        return FirstName == firstName && LastName == lastName && EmailAddress == email;

        //    return CheckProfile(firstName, lastName);
        //}
        //// Polymorphisme par héritge
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }
}
// favoré :  fluentAPI >> data Annotations >> Configuration par defaut 