using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CreateMessageFromEmailToMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Messages",
                table: "SubScribes");

            migrationBuilder.DropColumn(
                name: "Subjects",
                table: "SubScribes");

            migrationBuilder.CreateTable(
                name: "MessageFromEmailToMes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Subjects = table.Column<string>(nullable: true),
                    Messages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageFromEmailToMes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageFromEmailToMes");

            migrationBuilder.AddColumn<string>(
                name: "Messages",
                table: "SubScribes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subjects",
                table: "SubScribes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
