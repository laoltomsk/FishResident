using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class FixFeatureRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureRequests_Features_FeatureId",
                table: "FeatureRequests");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "FeatureRequests",
                newName: "FeatureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureRequests_FeatureId",
                table: "FeatureRequests",
                newName: "IX_FeatureRequests_FeatureTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureRequests_FeatureTypes_FeatureTypeId",
                table: "FeatureRequests",
                column: "FeatureTypeId",
                principalTable: "FeatureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureRequests_FeatureTypes_FeatureTypeId",
                table: "FeatureRequests");

            migrationBuilder.RenameColumn(
                name: "FeatureTypeId",
                table: "FeatureRequests",
                newName: "FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureRequests_FeatureTypeId",
                table: "FeatureRequests",
                newName: "IX_FeatureRequests_FeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureRequests_Features_FeatureId",
                table: "FeatureRequests",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
