using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Data.Migrations
{
    public partial class ApplicationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salary_Users_UserIdId",
                table: "salary");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "salary",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_salary_UserIdId",
                table: "salary",
                newName: "IX_salary_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_salary_Users_userId",
                table: "salary",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salary_Users_userId",
                table: "salary");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "salary",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_salary_userId",
                table: "salary",
                newName: "IX_salary_UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_salary_Users_UserIdId",
                table: "salary",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
