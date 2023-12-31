﻿// <auto-generated />
using System;
using DeltaDriveBE.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeltaDriveBE.Migrations
{
    [DbContext(typeof(APIDBContext))]
    [Migration("20231101144043_AdditionalFunctionalityy")]
    partial class AdditionalFunctionalityy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeltaDriveBE.Models.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Latitude")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double>("PricePerKm")
                        .HasColumnType("float");

                    b.Property<double>("StartPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("DeltaDriveBE.Models.Passenger", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Passangers");
                });

            modelBuilder.Entity("DeltaDriveBE.Models.Ride", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DestinationLatitude")
                        .HasColumnType("float");

                    b.Property<double>("DestinationLongitude")
                        .HasColumnType("float");

                    b.Property<Guid>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PassengerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RideStatus")
                        .HasColumnType("int");

                    b.Property<double>("StartLatitude")
                        .HasColumnType("float");

                    b.Property<double>("StartLongitude")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("DeltaDriveBE.Models.Ride", b =>
                {
                    b.HasOne("DeltaDriveBE.Models.Driver", "Driver")
                        .WithMany("RideHistory")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeltaDriveBE.Models.Passenger", "Passenger")
                        .WithMany("RideHistory")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("DeltaDriveBE.Models.Driver", b =>
                {
                    b.Navigation("RideHistory");
                });

            modelBuilder.Entity("DeltaDriveBE.Models.Passenger", b =>
                {
                    b.Navigation("RideHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
