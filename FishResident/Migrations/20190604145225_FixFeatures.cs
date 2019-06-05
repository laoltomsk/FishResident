using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class FixFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureAllowedValues_Features_FeatureId",
                table: "FeatureAllowedValues");

            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "FeatureAllowedValues",
                newName: "FeatureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureAllowedValues_FeatureId",
                table: "FeatureAllowedValues",
                newName: "IX_FeatureAllowedValues_FeatureTypeId");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "FeatureTypes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FeatureValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureValues_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureValues_FeatureId",
                table: "FeatureValues",
                column: "FeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureAllowedValues_FeatureTypes_FeatureTypeId",
                table: "FeatureAllowedValues",
                column: "FeatureTypeId",
                principalTable: "FeatureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureAllowedValues_FeatureTypes_FeatureTypeId",
                table: "FeatureAllowedValues");

            migrationBuilder.DropTable(
                name: "FeatureValues");

            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "FeatureTypes");

            migrationBuilder.RenameColumn(
                name: "FeatureTypeId",
                table: "FeatureAllowedValues",
                newName: "FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureAllowedValues_FeatureTypeId",
                table: "FeatureAllowedValues",
                newName: "IX_FeatureAllowedValues_FeatureId");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "Features",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Features",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureAllowedValues_Features_FeatureId",
                table: "FeatureAllowedValues",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
