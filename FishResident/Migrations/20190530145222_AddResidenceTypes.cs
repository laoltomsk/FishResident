using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddResidenceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Residences",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ResidenceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residences_TypeId",
                table: "Residences",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_ResidenceType_TypeId",
                table: "Residences",
                column: "TypeId",
                principalTable: "ResidenceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residences_ResidenceType_TypeId",
                table: "Residences");

            migrationBuilder.DropTable(
                name: "ResidenceType");

            migrationBuilder.DropIndex(
                name: "IX_Residences_TypeId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Residences");
        }
    }
}
