using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class AddedJamAttendees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JamAttendeesId",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendeesId",
                table: "Jams",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JamAttendees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JamAttendees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 11, 59, 0, 234, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_JamAttendeesId",
                table: "Profiles",
                column: "JamAttendeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Jams_AttendeesId",
                table: "Jams",
                column: "AttendeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jams_JamAttendees_AttendeesId",
                table: "Jams",
                column: "AttendeesId",
                principalTable: "JamAttendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_JamAttendees_JamAttendeesId",
                table: "Profiles",
                column: "JamAttendeesId",
                principalTable: "JamAttendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jams_JamAttendees_AttendeesId",
                table: "Jams");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_JamAttendees_JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "JamAttendees");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Jams_AttendeesId",
                table: "Jams");

            migrationBuilder.DropColumn(
                name: "JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AttendeesId",
                table: "Jams");

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 11, 56, 27, 15, DateTimeKind.Local).AddTicks(2828));
        }
    }
}
