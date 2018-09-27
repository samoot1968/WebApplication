using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Data.Migrations
{
    public partial class ApplicationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salary_Users_UseridId",
                table: "salary");

            migrationBuilder.RenameColumn(
                name: "UseridId",
                table: "salary",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_salary_UseridId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salary_Users_UserIdId",
                table: "salary");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "salary",
                newName: "UseridId");

            migrationBuilder.RenameIndex(
                name: "IX_salary_UserIdId",
                table: "salary",
                newName: "IX_salary_UseridId");

            migrationBuilder.AddForeignKey(
                name: "FK_salary_Users_UseridId",
                table: "salary",
                column: "UseridId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
