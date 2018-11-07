using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class vehiclecategorysuggestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorySuggestion",
                table: "VehicleModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorySuggestion",
                table: "VehicleModel");
        }
    }
}
