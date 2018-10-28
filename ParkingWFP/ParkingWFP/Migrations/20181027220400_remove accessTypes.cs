using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ParkingWFP.Migrations
{
    public partial class removeaccessTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AccessType_AccessTypeIdAccessType",
                table: "User");

            migrationBuilder.DropTable(
                name: "AccessType");

            migrationBuilder.DropIndex(
                name: "IX_User_AccessTypeIdAccessType",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccessTypeIdAccessType",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "AccessType",
                table: "User",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessType",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "AccessTypeIdAccessType",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AccessType",
                columns: table => new
                {
                    IdAccessType = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Access = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessType", x => x.IdAccessType);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AccessTypeIdAccessType",
                table: "User",
                column: "AccessTypeIdAccessType");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AccessType_AccessTypeIdAccessType",
                table: "User",
                column: "AccessTypeIdAccessType",
                principalTable: "AccessType",
                principalColumn: "IdAccessType",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
