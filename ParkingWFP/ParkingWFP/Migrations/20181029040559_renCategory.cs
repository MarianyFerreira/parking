using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class renCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "VehicleCategory",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "VehicleCategory",
                newName: "IdVehicleCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "VehicleCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdVehicleCategory",
                table: "VehicleCategory",
                newName: "IdCategory");
        }
    }
}
