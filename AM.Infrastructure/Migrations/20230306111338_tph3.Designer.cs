﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AmContext))]
    [Migration("20230306111338_tph3")]
    partial class tph3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"));

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("date");

                    b.Property<float>("EstimatedDuration")
                        .HasColumnType("real");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("date");

                    b.Property<int?>("PassengerPassportNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PlaneFk")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("PassengerPassportNumber");

                    b.HasIndex("PlaneFk");

                    b.ToTable("Vols", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Property<int>("PassportNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassportNumber"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("isTraveller")
                        .HasColumnType("int");

                    b.HasKey("PassportNumber");

                    b.ToTable("Passengers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Property<int>("PlaneKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneKey"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("PlaneCapacity");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("date");

                    b.Property<int>("PlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneKey");

                    b.ToTable("MyPlane", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Ticket", b =>
                {
                    b.Property<int>("FlightFK")
                        .HasColumnType("int");

                    b.Property<int>("PassengerFK")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasPrecision(3, 2)
                        .HasColumnType("float(3)");

                    b.Property<string>("Siege")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<bool>("VIP")
                        .HasColumnType("bit");

                    b.HasKey("FlightFK", "PassengerFK");

                    b.HasIndex("PassengerFK");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("date");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<string>("function")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.ToTable("Staffs", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<string>("HealthInformation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.ToTable("Travellers", (string)null);
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithMany("Flights")
                        .HasForeignKey("PassengerPassportNumber");

                    b.HasOne("AM.ApplicationCore.Domain.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneFk")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.OwnsOne("AM.ApplicationCore.FullName", "FullName", b1 =>
                        {
                            b1.Property<int>("PassengerPassportNumber")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("varchar")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("varchar")
                                .HasColumnName("LastName");

                            b1.HasKey("PassengerPassportNumber");

                            b1.ToTable("Passengers");

                            b1.WithOwner()
                                .HasForeignKey("PassengerPassportNumber");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Ticket", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Staff", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithOne()
                        .HasForeignKey("AM.ApplicationCore.Domain.Traveller", "PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Navigation("Flights");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
