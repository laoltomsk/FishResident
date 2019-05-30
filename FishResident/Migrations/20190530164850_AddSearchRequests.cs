using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddSearchRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SearchRequestId",
                table: "Residences",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SearchRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchRequest_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residences_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchRequest_UserId",
                table: "SearchRequest",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_SearchRequest_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId",
                principalTable: "SearchRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_SearchRequest_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropTable(
                name: "SearchRequest");

            migrationBuilder.DropIndex(
                name: "IX_Residences_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "SearchRequestId",
                table: "Residences");
        }
    }
}
