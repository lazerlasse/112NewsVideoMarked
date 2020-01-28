using Microsoft.EntityFrameworkCore.Migrations;

namespace _112NewsVideoMarked.Data.Migrations
{
    public partial class AddedOwnerIDToCaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "CaseContent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "CaseContent");
        }
    }
}
