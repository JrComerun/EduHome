using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class AddTeacherAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Courses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ProfessionOfTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionOfTeacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedTime = table.Column<DateTime>(nullable: true),
                    ProfessionOfTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_ProfessionOfTeacher_ProfessionOfTeacherId",
                        column: x => x.ProfessionOfTeacherId,
                        principalTable: "ProfessionOfTeacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailOfTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMe = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    MailMe = table.Column<string>(nullable: true),
                    MakeACall = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false),
                    LanguageValue = table.Column<int>(nullable: false),
                    TeamLeaderValue = table.Column<int>(nullable: false),
                    DevelopmentValue = table.Column<int>(nullable: false),
                    DesignValue = table.Column<int>(nullable: false),
                    InnovtionValue = table.Column<int>(nullable: false),
                    ComunicationValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOfTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailOfTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocMedOfTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocMedOfTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocMedOfTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailOfTeachers_TeacherId",
                table: "DetailOfTeachers",
                column: "TeacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocMedOfTeachers_TeacherId",
                table: "SocMedOfTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ProfessionOfTeacherId",
                table: "Teachers",
                column: "ProfessionOfTeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailOfTeachers");

            migrationBuilder.DropTable(
                name: "SocMedOfTeachers");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "ProfessionOfTeacher");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Courses");
        }
    }
}
