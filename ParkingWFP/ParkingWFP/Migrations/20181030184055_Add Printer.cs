using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ParkingWFP.Migrations
{
    public partial class AddPrinter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Printer");
        }
    }
}
