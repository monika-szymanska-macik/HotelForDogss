using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelForDogs.DataAccess.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Dogs_DogId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_DogId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DogId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_ClientId",
                table: "Dogs",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Clients_ClientId",
                table: "Dogs",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Clients_ClientId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_ClientId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Dogs");

            migrationBuilder.AddColumn<int>(
                name: "DogId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DogId",
                table: "Clients",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Dogs_DogId",
                table: "Clients",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
