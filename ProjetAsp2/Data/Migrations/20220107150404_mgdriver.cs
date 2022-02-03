using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAsp2.Data.Migrations
{
    public partial class mgdriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(maxLength: 30, nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Tel = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    DriverPicture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");
        }
    }
}
