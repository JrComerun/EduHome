using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class AddCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_DetailOfCourses_DetailOfCourseId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_DetailOfEvents_DetailOfEventId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DetailsOfBlogId",
                table: "Comments",
                newName: "IX_Comments_DetailsOfBlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DetailOfEventId",
                table: "Comments",
                newName: "IX_Comments_DetailOfEventId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DetailOfCourseId",
                table: "Comments",
                newName: "IX_Comments_DetailOfCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_DetailOfCourses_DetailOfCourseId",
                table: "Comments",
                column: "DetailOfCourseId",
                principalTable: "DetailOfCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_DetailOfEvents_DetailOfEventId",
                table: "Comments",
                column: "DetailOfEventId",
                principalTable: "DetailOfEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comments",
                column: "DetailsOfBlogId",
                principalTable: "DetailsOfBlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailOfCourses_DetailOfCourseId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailOfEvents_DetailOfEventId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DetailsOfBlogId",
                table: "Comment",
                newName: "IX_Comment_DetailsOfBlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DetailOfEventId",
                table: "Comment",
                newName: "IX_Comment_DetailOfEventId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DetailOfCourseId",
                table: "Comment",
                newName: "IX_Comment_DetailOfCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_DetailOfCourses_DetailOfCourseId",
                table: "Comment",
                column: "DetailOfCourseId",
                principalTable: "DetailOfCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_DetailOfEvents_DetailOfEventId",
                table: "Comment",
                column: "DetailOfEventId",
                principalTable: "DetailOfEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comment",
                column: "DetailsOfBlogId",
                principalTable: "DetailsOfBlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
