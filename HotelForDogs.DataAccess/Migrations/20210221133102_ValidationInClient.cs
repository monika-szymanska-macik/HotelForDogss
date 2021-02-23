using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelForDogs.DataAccess.Migrations
{
    public partial class ValidationInClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DogId",
                table: "Dogs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Dogs",
                newName: "DogId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientId");
        }
    }
}
