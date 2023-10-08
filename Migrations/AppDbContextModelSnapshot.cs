﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testApp.Data;

#nullable disable

namespace testApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
#pragma warning restore 612, 618
        }
    }
}
