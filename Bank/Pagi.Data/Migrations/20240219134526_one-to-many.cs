using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pagi.Data.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "turnId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_turnId",
                table: "Clients",
                column: "turnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Turns_turnId",
                table: "Clients",
                column: "turnId",
                principalTable: "Turns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Turns_turnId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_turnId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "turnId",
                table: "Clients");
        }
    }
}
