using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class ChangePropertyInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Messages",
                table: "SubScribes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subjects",
                table: "SubScribes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "SocialMedias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Messages",
                table: "SubScribes");

            migrationBuilder.DropColumn(
                name: "Subjects",
                table: "SubScribes");

            migrationBuilder.DropColumn(
                name: "IconName",
                table: "SocialMedias");
        }
    }
}
