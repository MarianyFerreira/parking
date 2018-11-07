using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class addtotalValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalValue",
                table: "Parking",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalValue",
                table: "Parking");
        }
    }
}
