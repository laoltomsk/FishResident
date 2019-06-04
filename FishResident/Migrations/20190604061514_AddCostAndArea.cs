using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddCostAndArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Features_LinkedFeatureId",
                table: "Features");

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Residences",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Residences",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<Guid>(
                name: "LinkedFeatureId",
                table: "Features",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Features_LinkedFeatureId",
                table: "Features",
                column: "LinkedFeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Features_LinkedFeatureId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Residences");

            migrationBuilder.AlterColumn<Guid>(
                name: "LinkedFeatureId",
                table: "Features",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Features_LinkedFeatureId",
                table: "Features",
                column: "LinkedFeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
