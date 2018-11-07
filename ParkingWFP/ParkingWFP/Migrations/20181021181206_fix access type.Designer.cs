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
    [Migration("20181021181206_fix access type")]
    partial class fixaccesstype
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ParkingWFP.Model.AccessType", b =>
                {
                    b.Property<int>("IdAccessType")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Access")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("IdAccessType");

                    b.ToTable("AccessType");
                });

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

                    b.Property<int>("AccessTypeIdAccessType");

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

                    b.HasIndex("AccessTypeIdAccessType");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ParkingWFP.Model.User", b =>
                {
                    b.HasOne("ParkingWFP.Model.AccessType", "AccessType")
                        .WithMany()
                        .HasForeignKey("AccessTypeIdAccessType")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
