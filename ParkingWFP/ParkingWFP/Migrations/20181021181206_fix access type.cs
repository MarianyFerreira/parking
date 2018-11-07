using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingWFP.Migrations
{
    public partial class fixaccesstype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AcessType_AccessTypeIdAcessType",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcessType",
                table: "AcessType");

            migrationBuilder.RenameTable(
                name: "AcessType",
                newName: "AccessType");

            migrationBuilder.RenameColumn(
                name: "AccessTypeIdAcessType",
                table: "User",
                newName: "AccessTypeIdAccessType");

            migrationBuilder.RenameIndex(
                name: "IX_User_AccessTypeIdAcessType",
                table: "User",
                newName: "IX_User_AccessTypeIdAccessType");

            migrationBuilder.RenameColumn(
                name: "AcessType",
                table: "AccessType",
                newName: "Access");

            migrationBuilder.RenameColumn(
                name: "IdAcessType",
                table: "AccessType",
                newName: "IdAccessType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessType",
                table: "AccessType",
                column: "IdAccessType");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AccessType_AccessTypeIdAccessType",
                table: "User",
                column: "AccessTypeIdAccessType",
                principalTable: "AccessType",
                principalColumn: "IdAccessType",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AccessType_AccessTypeIdAccessType",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessType",
                table: "AccessType");

            migrationBuilder.RenameTable(
                name: "AccessType",
                newName: "AcessType");

            migrationBuilder.RenameColumn(
                name: "AccessTypeIdAccessType",
                table: "User",
                newName: "AccessTypeIdAcessType");

            migrationBuilder.RenameIndex(
                name: "IX_User_AccessTypeIdAccessType",
                table: "User",
                newName: "IX_User_AccessTypeIdAcessType");

            migrationBuilder.RenameColumn(
                name: "Access",
                table: "AcessType",
                newName: "AcessType");

            migrationBuilder.RenameColumn(
                name: "IdAccessType",
                table: "AcessType",
                newName: "IdAcessType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcessType",
                table: "AcessType",
                column: "IdAcessType");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AcessType_AccessTypeIdAcessType",
                table: "User",
                column: "AccessTypeIdAcessType",
                principalTable: "AcessType",
                principalColumn: "IdAcessType",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
