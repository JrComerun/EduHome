using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class CreateBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutAreas",
                table: "AboutAreas");

            migrationBuilder.RenameTable(
                name: "AboutAreas",
                newName: "AboutArea");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutArea",
                table: "AboutArea",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogo = table.Column<string>(nullable: true),
                    FooterLogo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutArea",
                table: "AboutArea");

            migrationBuilder.RenameTable(
                name: "AboutArea",
                newName: "AboutAreas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutAreas",
                table: "AboutAreas",
                column: "Id");
        }
    }
}
