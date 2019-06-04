using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddEverythingElse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SearchRequestId",
                table: "Residences",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Residences",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ResidenceId = table.Column<Guid>(nullable: false),
                    ResidentId = table.Column<string>(nullable: false),
                    OwnerId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agreements_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agreements_Residences_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Residences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Agreements_AspNetUsers_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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
                name: "ResidenceTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SearchRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    LinkedFeatureId = table.Column<Guid>(nullable: true),
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
                        onDelete: ReferentialAction.NoAction);
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
                name: "IX_Residences_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_TypeId",
                table: "Residences",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_OwnerId",
                table: "Agreements",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_ResidenceId",
                table: "Agreements",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_ResidentId",
                table: "Agreements",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureAllowedValues_FeatureId",
                table: "FeatureAllowedValues",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureRequests_FeatureId",
                table: "FeatureRequests",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureRequests_SearchRequestId",
                table: "FeatureRequests",
                column: "SearchRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_FeatureTypeId",
                table: "Features",
                column: "FeatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_LinkedFeatureId",
                table: "Features",
                column: "LinkedFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SearchRequests_UserId",
                table: "SearchRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences",
                column: "SearchRequestId",
                principalTable: "SearchRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Residences_SearchRequests_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropForeignKey(
                name: "FK_Residences_ResidenceTypes_TypeId",
                table: "Residences");

            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "FeatureAllowedValues");

            migrationBuilder.DropTable(
                name: "FeatureRequests");

            migrationBuilder.DropTable(
                name: "ResidenceTypes");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "SearchRequests");

            migrationBuilder.DropTable(
                name: "FeatureTypes");

            migrationBuilder.DropIndex(
                name: "IX_Residences_SearchRequestId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_TypeId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "SearchRequestId",
                table: "Residences");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Residences");
        }
    }
}
