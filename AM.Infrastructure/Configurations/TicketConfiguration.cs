using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(p => new { p.FlightFk, p.PassengerFk });



            // foreign key avec code ou bien avec annotations
            builder.HasOne(t => t.Passenger)
                .WithMany(p => p.Tickets)
                .HasForeignKey(p => p.PassengerFk);
            builder.HasOne(t => t.Flight)
                .WithMany(p => p.Tickets)
                .HasForeignKey(p => p.FlightFk);
        }
    }
}
