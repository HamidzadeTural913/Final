using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Final_Project_Staffy.Migrations
{
    public partial class DifficultChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Vacations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EducationId",
                table: "Vacations",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Education_EducationId",
                table: "Vacations",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Education_EducationId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_EducationId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Vacations");
        }
    }
}
