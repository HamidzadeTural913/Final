using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class deleteappuserfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_AspNetUsers_AppUserId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_AppUserId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vacations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Vacations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Vacations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_AppUserId",
                table: "Vacations",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_AspNetUsers_AppUserId",
                table: "Vacations",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
