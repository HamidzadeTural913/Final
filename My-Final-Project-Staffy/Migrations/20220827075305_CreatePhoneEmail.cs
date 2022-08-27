using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class CreatePhoneEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Vacations",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "Vacations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Vacations",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Information",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Vacations");
        }
    }
}
