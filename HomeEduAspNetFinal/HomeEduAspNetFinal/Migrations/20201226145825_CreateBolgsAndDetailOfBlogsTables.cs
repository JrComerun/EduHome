using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CreateBolgsAndDetailOfBlogsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false,defaultValue:DateTime.UtcNow),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpikersOfEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DetailOfEventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpikersOfEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpikersOfEvents_DetailOfEvents_DetailOfEventId",
                        column: x => x.DetailOfEventId,
                        principalTable: "DetailOfEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailsOfBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsOfBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsOfBlogs_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CourseId",
                table: "Blogs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsOfBlogs_BlogId",
                table: "DetailsOfBlogs",
                column: "BlogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpikersOfEvents_DetailOfEventId",
                table: "SpikersOfEvents",
                column: "DetailOfEventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsOfBlogs");

            migrationBuilder.DropTable(
                name: "SpikersOfEvents");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
