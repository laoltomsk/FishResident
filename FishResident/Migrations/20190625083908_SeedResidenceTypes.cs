using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class SeedResidenceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ResidenceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dfec4b1f-b5de-432d-919b-e83a675ccf96"), "House" },
                    { new Guid("af3a041c-6848-46e8-b0cc-44bce4bca869"), "Flat" },
                    { new Guid("c16c4cdb-896c-4eac-969a-f52485e7d926"), "Cottage" },
                    { new Guid("4c6198f1-384e-47e3-af43-63397fed6020"), "Bungalow" },
                    { new Guid("08fa6093-cd03-4860-a30d-5593851e7d38"), "Park home" },
                    { new Guid("2053501c-d984-4eb0-b0b0-d4f89187ba2e"), "Maisonette" },
                    { new Guid("691ce1c6-09ac-439a-8b91-70f5028a772a"), "Mansion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("08fa6093-cd03-4860-a30d-5593851e7d38"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("2053501c-d984-4eb0-b0b0-d4f89187ba2e"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c6198f1-384e-47e3-af43-63397fed6020"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("691ce1c6-09ac-439a-8b91-70f5028a772a"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("af3a041c-6848-46e8-b0cc-44bce4bca869"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("c16c4cdb-896c-4eac-969a-f52485e7d926"));

            migrationBuilder.DeleteData(
                table: "ResidenceTypes",
                keyColumn: "Id",
                keyValue: new Guid("dfec4b1f-b5de-432d-919b-e83a675ccf96"));
        }
    }
}
