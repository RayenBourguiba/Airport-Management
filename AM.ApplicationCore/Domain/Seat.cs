using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        [Required(ErrorMessage ="Name est obligatoire")]
        [MinLength(1, ErrorMessage ="doit etre > 1")]
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        [Range(0, 20)]
        public int Size { get; set; }
        public virtual Section Section { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public int? SectionFK { get; set; }
    }
}
