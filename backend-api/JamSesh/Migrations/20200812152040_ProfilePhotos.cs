using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class ProfilePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 20, 38, 729, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 20, 38, 750, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 20, 38, 750, DateTimeKind.Local).AddTicks(4881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 12, 55, 76, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 12, 55, 80, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2020, 8, 12, 11, 12, 55, 80, DateTimeKind.Local).AddTicks(5107));
        }
    }
}
