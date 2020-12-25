using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class ChangeCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Starts",
                table: "DetailOfCourses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Starts",
                table: "DetailOfCourses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
