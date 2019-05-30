using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_ResidenceType_TypeId",
                table: "Residences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResidenceType",
                table: "ResidenceType");

            migrationBuilder.RenameTable(
                name: "ResidenceType",
                newName: "ResidenceTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResidenceTypes",
                table: "ResidenceTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FeatureTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    LinkedFeatureId = table.Column<Guid>(nullable: false),
                    FeatureTypeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_FeatureTypes_FeatureTypeId",
                        column: x => x.FeatureTypeId,
                        principalTable: "FeatureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Features_Features_LinkedFeatureId",
                        column: x => x.LinkedFeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureAllowedValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    FeatureId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureAllowedValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureAllowedValues_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureAllowedValues_FeatureId",
                table: "FeatureAllowedValues",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_FeatureTypeId",
                table: "Features",
                column: "FeatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_LinkedFeatureId",
                table: "Features",
                column: "LinkedFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_ResidenceTypes_TypeId",
                table: "Residences",
                column: "TypeId",
                principalTable: "ResidenceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_ResidenceTypes_TypeId",
                table: "Residences");

            migrationBuilder.DropTable(
                name: "FeatureAllowedValues");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "FeatureTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResidenceTypes",
                table: "ResidenceTypes");

            migrationBuilder.RenameTable(
                name: "ResidenceTypes",
                newName: "ResidenceType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResidenceType",
                table: "ResidenceType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_ResidenceType_TypeId",
                table: "Residences",
                column: "TypeId",
                principalTable: "ResidenceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
