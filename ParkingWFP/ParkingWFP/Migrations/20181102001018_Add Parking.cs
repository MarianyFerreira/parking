using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ParkingWFP.Migrations
{
    public partial class AddParking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parking",
                columns: table => new
                {
                    IdParking = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Plate = table.Column<string>(nullable: false),
                    VehicleModel = table.Column<int>(nullable: false),
                    VehicleCategory = table.Column<int>(nullable: false),
                    VehicleColor = table.Column<int>(nullable: false),
                    StartedAt = table.Column<DateTime>(nullable: false),
                    FinalizedAt = table.Column<DateTime>(nullable: false),
                    CanceledAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.IdParking);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parking");
        }
    }
}
