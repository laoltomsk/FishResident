using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddRequestResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "SearchRequestId",
                table: "Residences");

            migrationBuilder.CreateTable(
                name: "RequestResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Relevance = table.Column<double>(nullable: false),
                    SearchRequestId = table.Column<Guid>(nullable: false),
                    ResidenceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestResults_Residences_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RequestResults_SearchRequests_SearchRequestId",
                        column: x => x.SearchRequestId,
                        principalTable: "SearchRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestResults_ResidenceId",
                table: "RequestResults",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestResults_SearchRequestId",
                table: "RequestResults",
                column: "SearchRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestResults");

            migrationBuilder.AddColumn<Guid>(
                name: "SearchRequestId",
                table: "Residences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Residences_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId",
                principalTable: "SearchRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
