using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //[Owned]
    public class FullName
    {
  //     [MaxLength(30 , ErrorMessage = "doit etre < 30 ")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
