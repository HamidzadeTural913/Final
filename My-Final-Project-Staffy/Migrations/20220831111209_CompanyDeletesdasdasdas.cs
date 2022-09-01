using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class CompanyDeletesdasdasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChoose",
                table: "Vacations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChoose",
                table: "Vacations");
        }
    }
}
