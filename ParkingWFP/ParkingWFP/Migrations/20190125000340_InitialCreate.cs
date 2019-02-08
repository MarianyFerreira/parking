using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ParkingWFP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    IdParking = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(nullable: false),
                    Plate = table.Column<string>(nullable: false),
                    VehicleModel = table.Column<int>(nullable: false),
                    VehicleCategory = table.Column<int>(nullable: false),
                    VehicleColor = table.Column<int>(nullable: false),
                    Increase = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    TotalValue = table.Column<double>(nullable: false),
                    RegisteredBy = table.Column<int>(nullable: false),
                    StartedAt = table.Column<DateTime>(nullable: false),
                    FinalizedAt = table.Column<DateTime>(nullable: false),
                    CanceledAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.IdParking);
                });

            migrationBuilder.CreateTable(
                name: "Printer",
                columns: table => new
                {
                    IdPrinter = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Model = table.Column<int>(nullable: false),
                    Port = table.Column<string>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    Footer = table.Column<string>(nullable: true),
                    Font = table.Column<int>(nullable: false),
                    Italic = table.Column<int>(nullable: false),
                    Underline = table.Column<int>(nullable: false),
                    Expanded = table.Column<int>(nullable: false),
                    Bold = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printer", x => x.IdPrinter);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Username = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Fullname = table.Column<string>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    AccessType = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategory",
                columns: table => new
                {
                    IdVehicleCategory = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Category = table.Column<string>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Tolerance = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategory", x => x.IdVehicleCategory);
                });

            migrationBuilder.CreateTable(
                name: "VehicleColor",
                columns: table => new
                {
                    IdVehicleColor = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Color = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColor", x => x.IdVehicleColor);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    IdVehicleModel = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Model = table.Column<string>(nullable: false),
                    CategorySuggestion = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.IdVehicleModel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parking");

            migrationBuilder.DropTable(
                name: "Printer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VehicleCategory");

            migrationBuilder.DropTable(
                name: "VehicleColor");

            migrationBuilder.DropTable(
                name: "VehicleModel");
        }
    }
}
