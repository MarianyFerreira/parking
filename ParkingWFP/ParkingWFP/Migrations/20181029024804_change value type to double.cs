using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class changevaluetypetodouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Category",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "Category",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
