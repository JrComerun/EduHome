using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class ChangeRelationCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailOfCourses_DetailOfCourseId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_DetailOfEvents_DetailOfEventId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DetailOfCourseId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DetailOfEventId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DetailOfBlogId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DetailOfCourseId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DetailOfEventId",
                table: "Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "SpikersOfEvents",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SpikersOfEvents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "SocMedOfTeachers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SocMedOfTeachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "ProfessionOfTeacher",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProfessionOfTeacher",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "DetailOfTeachers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DetailOfTeachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "DetailOfEvents",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DetailOfEvents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "DetailOfCourses",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DetailOfCourses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Blogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CourseId",
                table: "Comments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventId",
                table: "Comments",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Courses_CourseId",
                table: "Comments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Events_EventId",
                table: "Comments",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Courses_CourseId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Events_EventId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CourseId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EventId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "SpikersOfEvents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SpikersOfEvents");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "SocMedOfTeachers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SocMedOfTeachers");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "ProfessionOfTeacher");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProfessionOfTeacher");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "DetailOfTeachers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DetailOfTeachers");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "DetailOfEvents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DetailOfEvents");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "DetailOfCourses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DetailOfCourses");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "DetailOfBlogId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailOfCourseId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailOfEventId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DetailOfCourseId",
                table: "Comments",
                column: "DetailOfCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DetailOfEventId",
                table: "Comments",
                column: "DetailOfEventId");

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
        }
    }
}
