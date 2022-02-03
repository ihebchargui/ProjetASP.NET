using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetAsp2.Data.Migrations
{
    public partial class mgCarRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "RentCar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RentCar_DriverId",
                table: "RentCar",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentCar_Driver_DriverId",
                table: "RentCar",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentCar_Driver_DriverId",
                table: "RentCar");

            migrationBuilder.DropIndex(
                name: "IX_RentCar_DriverId",
                table: "RentCar");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "RentCar");
        }
    }
}
