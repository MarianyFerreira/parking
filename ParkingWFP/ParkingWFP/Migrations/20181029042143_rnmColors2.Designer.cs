﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ParkingWFP.Model;

namespace ParkingWFP.Migrations
{
    [DbContext(typeof(ParkingContext))]
    [Migration("20181029042143_rnmColors2")]
    partial class rnmColors2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ParkingWFP.Model.Printer", b =>
                {
                    b.Property<int>("IdPrinter")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Footer");

                    b.Property<string>("Header");

                    b.Property<string>("Host")
                        .IsRequired();

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<string>("Port")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("IdPrinter");

                    b.ToTable("Printer");
                });

            modelBuilder.Entity("ParkingWFP.Model.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessType")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("Enabled");

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("IdUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ParkingWFP.Model.VehicleCategory", b =>
                {
                    b.Property<int>("IdVehicleCategory")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Tolerance");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<double>("Value");

                    b.HasKey("IdVehicleCategory");

                    b.ToTable("VehicleCategory");
                });

            modelBuilder.Entity("ParkingWFP.Model.VehicleColor", b =>
                {
                    b.Property<int>("IdVehicleColor")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("IdVehicleColor");

                    b.ToTable("VehicleColor");
                });

            modelBuilder.Entity("ParkingWFP.Model.VehicleModel", b =>
                {
                    b.Property<int>("IdVehicleModel")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("IdVehicleModel");

                    b.ToTable("VehicleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
