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
    public class PassangersConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
        //    builder.Property(p => p.FirstName)
        //        .IsRequired()
        //        .HasMaxLength(80)
        //        .HasDefaultValue("name")
        //        .HasColumnType("nchar");

            builder.OwnsOne(p => p.FullName , f =>
            {
                f.Property(a => a.FirstName).HasColumnName("FirstName")
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(30);
                f.Property(b => b.LastName).HasColumnName("PassLastName")
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(30);
            });

            //builder.HasDiscriminator<int>("IsTraveller")
            //    .HasValue<Passenger>(1)
            //    .HasValue<Staff>(2)
            //    .HasValue(0);
        }
    }
}
