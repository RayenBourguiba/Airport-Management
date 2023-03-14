using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //Configuration fluent API 
            builder.HasKey(f => f.FlightId);
            // changement de nom de table au niveau de DB
            builder.ToTable("Vols");

            //configuration OneToMany 1..*
            builder.HasOne(f => f.Plane)
                   .WithMany(p => p.Flights)
                   .HasForeignKey(f => f.PlaneFk)
                   .OnDelete(DeleteBehavior.SetNull);


            //configuration *..*

            //builder.HasMany(f => f.Passengers)
            //       .WithMany(p => p.Flights)
            //       .UsingEntity(pf => pf.ToTable("MyReservations"));

        }
    }
}
