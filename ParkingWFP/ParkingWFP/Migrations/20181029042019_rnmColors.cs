using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class rnmColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "VehicleColor");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "VehicleColor",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "IdColor",
                table: "VehicleColor",
                newName: "IdVehicleColor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleColor",
                table: "VehicleColor",
                column: "IdVehicleColor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleColor",
                table: "VehicleColor");

            migrationBuilder.RenameTable(
                name: "VehicleColor",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Color",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdVehicleColor",
                table: "Color",
                newName: "IdColor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "IdColor");
        }
    }
}
