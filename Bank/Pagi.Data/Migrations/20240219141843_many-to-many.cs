using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pagi.Data.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClerkClient",
                columns: table => new
                {
                    ClerksId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClerkClient", x => new { x.ClerksId, x.ClientsId });
                    table.ForeignKey(
                        name: "FK_ClerkClient_Clerks_ClerksId",
                        column: x => x.ClerksId,
                        principalTable: "Clerks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClerkClient_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClerkClient_ClientsId",
                table: "ClerkClient",
                column: "ClientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClerkClient");
        }
    }
}
