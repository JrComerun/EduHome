using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CourseandDetailRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailOfCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutCourse = table.Column<string>(nullable: true),
                    HowToApply = table.Column<string>(nullable: true),
                    Certification = table.Column<string>(nullable: true),
                    Starts = table.Column<DateTime>(nullable: true,defaultValue:DateTime.UtcNow),
                    Duration = table.Column<string>(nullable: true),
                    ClassDuration = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Students = table.Column<int>(nullable: false),
                    Assesments = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOfCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailOfCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailOfCourses_CourseId",
                table: "DetailOfCourses",
                column: "CourseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailOfCourses");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
