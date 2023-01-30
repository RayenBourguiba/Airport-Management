using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Etudiant:Personne
    {
        public string Class { get; set; }
        public string Speciality { get; set; }
        public string Matricule { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("I'm a student");
        }
    }
}
