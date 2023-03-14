using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Section
    {
        [Key]
        public int IdSection { get; set; }
        public string Name { get; set; }
        public virtual List<Seat> Seats { get; set;}

    }
}
