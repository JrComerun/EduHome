using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeEduAspNetFinal.Migrations
{
    public partial class EventAddSpikersOfEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "SpikersOfEvents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpikersOfEvents_EventId",
                table: "SpikersOfEvents",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpikersOfEvents_Events_EventId",
                table: "SpikersOfEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpikersOfEvents_Events_EventId",
                table: "SpikersOfEvents");

            migrationBuilder.DropIndex(
                name: "IX_SpikersOfEvents_EventId",
                table: "SpikersOfEvents");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "SpikersOfEvents");
        }
    }
}
