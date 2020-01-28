using Microsoft.EntityFrameworkCore.Migrations;

namespace _112NewsVideoMarked.Data.Migrations
{
    public partial class RemovedIdentityUserFormCaseContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseContent_AspNetUsers_UserId",
                table: "CaseContent");

            migrationBuilder.DropIndex(
                name: "IX_CaseContent_UserId",
                table: "CaseContent");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CaseContent");

            migrationBuilder.AlterColumn<string>(
                name: "Photographer",
                table: "CaseContent",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photographer",
                table: "CaseContent",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CaseContent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CaseContent_UserId",
                table: "CaseContent",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseContent_AspNetUsers_UserId",
                table: "CaseContent",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
