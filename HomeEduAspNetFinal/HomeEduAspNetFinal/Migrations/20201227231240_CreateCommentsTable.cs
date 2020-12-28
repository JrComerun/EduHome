using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CreateCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Courses_CourseId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    DetailOfEventId = table.Column<int>(nullable: true),
                    DetailOfCourseId = table.Column<int>(nullable: true),
                    DetailOfBlogId = table.Column<int>(nullable: true),
                    DetailsOfBlogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_DetailOfCourses_DetailOfCourseId",
                        column: x => x.DetailOfCourseId,
                        principalTable: "DetailOfCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_DetailOfEvents_DetailOfEventId",
                        column: x => x.DetailOfEventId,
                        principalTable: "DetailOfEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_DetailsOfBlogs_DetailsOfBlogId",
                        column: x => x.DetailsOfBlogId,
                        principalTable: "DetailsOfBlogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_EventId",
                table: "Blogs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_DetailOfCourseId",
                table: "Comment",
                column: "DetailOfCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_DetailOfEventId",
                table: "Comment",
                column: "DetailOfEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_DetailsOfBlogId",
                table: "Comment",
                column: "DetailsOfBlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Courses_CourseId",
                table: "Blogs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Events_EventId",
                table: "Blogs",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Courses_CourseId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Events_EventId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_EventId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Courses_CourseId",
                table: "Blogs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
