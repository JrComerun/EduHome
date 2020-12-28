using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class ChangeCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DetailsOfBlogId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DetailsOfBlogId",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetailsOfBlogId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DetailsOfBlogId",
                table: "Comments",
                column: "DetailsOfBlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_DetailsOfBlogs_DetailsOfBlogId",
                table: "Comments",
                column: "DetailsOfBlogId",
                principalTable: "DetailsOfBlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
