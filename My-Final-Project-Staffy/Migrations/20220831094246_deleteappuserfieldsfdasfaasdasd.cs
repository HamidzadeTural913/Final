using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class deleteappuserfieldsfdasfaasdasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Vacations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Vacations");
        }
    }
}
