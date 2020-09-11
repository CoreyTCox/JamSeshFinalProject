using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class ProfileJamDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 12, 14, 9, 10, 419, DateTimeKind.Local).AddTicks(6365), "High-Voltage-Acoustic-Rock.jpg" });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 12, 14, 9, 10, 427, DateTimeKind.Local).AddTicks(2707), "Castle-Noel.jpg" });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 12, 14, 9, 10, 427, DateTimeKind.Local).AddTicks(2885), "Church.jpg" });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "Image",
                value: "AvatarImage1.png");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2,
                column: "Image",
                value: "AvatarImage2.png");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "Image",
                value: "AvatarImage3.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 7, 13, 51, 18, 620, DateTimeKind.Local).AddTicks(5908), "JamIcon.jpg" });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5766), "JamIcon.jpg" });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                columns: new[] { "EventDate", "Image" },
                values: new object[] { new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5903), "JamIcon.jpg" });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "Image",
                value: "DefaultProfilePhoto.jpg");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2,
                column: "Image",
                value: "DefaultProfilePhoto.jpg");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "Image",
                value: "DefaultProfilePhoto.jpg");
        }
    }
}
