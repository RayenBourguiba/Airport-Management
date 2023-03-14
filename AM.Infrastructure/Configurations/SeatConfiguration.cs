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
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            //configuration OneToMany 1..*
            builder.HasOne(f => f.Section)
                   .WithMany(p => p.Seats)
                   .HasForeignKey(f => f.SectionFK)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
