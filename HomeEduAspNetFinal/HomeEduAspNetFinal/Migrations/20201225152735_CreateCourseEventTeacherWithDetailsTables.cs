using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CreateCourseEventTeacherWithDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SayAboutUs",
                table: "Testimonials",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SayAboutUs",
                table: "Testimonials",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
