﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testApp.Data;

#nullable disable

namespace testApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231010062447_AddedPassengersTable")]
    partial class AddedPassengersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("testApp.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("OriginId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("OriginId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DestinationId = 4,
                            OriginId = 4
                        },
                        new
                        {
                            Id = 2,
                            DestinationId = 4,
                            OriginId = 4
                        },
                        new
                        {
                            Id = 3,
                            DestinationId = 1,
                            OriginId = 1
                        },
                        new
                        {
                            Id = 4,
                            DestinationId = 3,
                            OriginId = 3
                        },
                        new
                        {
                            Id = 5,
                            DestinationId = 4,
                            OriginId = 4
                        },
                        new
                        {
                            Id = 6,
                            DestinationId = 3,
                            OriginId = 3
                        },
                        new
                        {
                            Id = 7,
                            DestinationId = 1,
                            OriginId = 1
                        },
                        new
                        {
                            Id = 8,
                            DestinationId = 4,
                            OriginId = 4
                        },
                        new
                        {
                            Id = 9,
                            DestinationId = 2,
                            OriginId = 2
                        },
                        new
                        {
                            Id = 10,
                            DestinationId = 4,
                            OriginId = 4
                        });
                });

            modelBuilder.Entity("testApp.Models.Airport", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.HasKey("Id");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            Code = "JFK"
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Code = "HTR"
                        },
                        new
                        {
                            Id = 3,
                            City = "Paris",
                            Code = "CDH"
                        },
                        new
                        {
                            Id = 4,
                            City = "Rome",
                            Code = "RMA"
                        },
                        new
                        {
                            Id = 5,
                            City = "Shanghai",
                            Code = "SHA"
                        });
                });

            modelBuilder.Entity("testApp.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2000)");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("testApp.Flight", b =>
                {
                    b.HasOne("testApp.Models.Airport", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testApp.Models.Airport", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");

                    b.Navigation("Origin");
                });
#pragma warning restore 612, 618
        }
    }
}