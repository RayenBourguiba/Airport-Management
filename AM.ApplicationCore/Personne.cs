using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Personne
    {
        public int id { get; set; }
        public string name { get; set; }
        public string familyName { get; set; }
        public DateTime birthDate { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }



        public Personne(string name, string familyName, DateTime birthDate, string password, string confirmPassword, string email)
        {
            this.name = name;
            this.familyName = familyName;
            this.birthDate = birthDate;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
        }

        public Personne()
        {
        }

        public bool Login(string password, string confirmpassword, string? email=null)
        {
            if(email!=null) { return this.Password == password && this.ConfirmPassword == confirmpassword && this.Email == email; }
            else { return this.Password == password && this.ConfirmPassword == confirmpassword; }
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("I'm a person");
        }

        public override string ToString()
        {
            return $" {id}, {name}, {familyName}, {birthDate}";
        }
    }
}
