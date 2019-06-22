using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddFeatureResidenceCrossLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ResidenceId",
                table: "Features",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Features_ResidenceId",
                table: "Features",
                column: "ResidenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Residences_ResidenceId",
                table: "Features",
                column: "ResidenceId",
                principalTable: "Residences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Residences_ResidenceId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_ResidenceId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "ResidenceId",
                table: "Features");
        }
    }
}
