using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class changedAppuserfielddnjasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Vacations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vacations");
        }
    }
}
