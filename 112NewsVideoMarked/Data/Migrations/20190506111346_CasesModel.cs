using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _112NewsVideoMarked.Data.Migrations
{
    public partial class CasesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseContent",
                columns: table => new
                {
                    CaseContentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photographer = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Town = table.Column<string>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false),
                    CaseOwnerID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseContent", x => x.CaseContentID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageName = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    CaseContentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_Image_CaseContent_CaseContentID",
                        column: x => x.CaseContentID,
                        principalTable: "CaseContent",
                        principalColumn: "CaseContentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    VideoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VideoName = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true),
                    CaseContentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.VideoID);
                    table.ForeignKey(
                        name: "FK_Video_CaseContent_CaseContentID",
                        column: x => x.CaseContentID,
                        principalTable: "CaseContent",
                        principalColumn: "CaseContentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_CaseContentID",
                table: "Image",
                column: "CaseContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CaseContentID",
                table: "Video",
                column: "CaseContentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "CaseContent");
        }
    }
}
