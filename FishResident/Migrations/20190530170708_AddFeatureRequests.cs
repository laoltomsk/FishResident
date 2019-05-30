using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddFeatureRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_SearchRequest_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropForeignKey(
                name: "FK_SearchRequest_AspNetUsers_UserId",
                table: "SearchRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SearchRequest",
                table: "SearchRequest");

            migrationBuilder.RenameTable(
                name: "SearchRequest",
                newName: "SearchRequests");

            migrationBuilder.RenameIndex(
                name: "IX_SearchRequest_UserId",
                table: "SearchRequests",
                newName: "IX_SearchRequests_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SearchRequests",
                table: "SearchRequests",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FeatureRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    SearchRequestId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureRequests_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureRequests_SearchRequests_SearchRequestId",
                        column: x => x.SearchRequestId,
                        principalTable: "SearchRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureRequests_FeatureId",
                table: "FeatureRequests",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureRequests_SearchRequestId",
                table: "FeatureRequests",
                column: "SearchRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId",
                principalTable: "SearchRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SearchRequests_AspNetUsers_UserId",
                table: "SearchRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropForeignKey(
                name: "FK_SearchRequests_AspNetUsers_UserId",
                table: "SearchRequests");

            migrationBuilder.DropTable(
                name: "FeatureRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SearchRequests",
                table: "SearchRequests");

            migrationBuilder.RenameTable(
                name: "SearchRequests",
                newName: "SearchRequest");

            migrationBuilder.RenameIndex(
                name: "IX_SearchRequests_UserId",
                table: "SearchRequest",
                newName: "IX_SearchRequest_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SearchRequest",
                table: "SearchRequest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_SearchRequest_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId",
                principalTable: "SearchRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SearchRequest_AspNetUsers_UserId",
                table: "SearchRequest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
