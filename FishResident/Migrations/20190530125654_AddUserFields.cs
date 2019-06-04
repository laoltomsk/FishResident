using Microsoft.EntityFrameworkCore.Migrations;

namespace FishResident.Migrations
{
    public partial class AddUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contacts",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectOfficePhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralOfficePhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficePhoneExtension",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryEmail",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Contacts",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DirectOfficePhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GeneralOfficePhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OfficePhoneExtension",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecondaryEmail",
                table: "AspNetUsers");
        }
    }
}
