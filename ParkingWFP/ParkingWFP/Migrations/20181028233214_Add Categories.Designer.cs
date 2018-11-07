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
    [Migration("20181028233214_Add Categories")]
    partial class AddCategories
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
#pragma warning restore 612, 618
        }
    }
}
