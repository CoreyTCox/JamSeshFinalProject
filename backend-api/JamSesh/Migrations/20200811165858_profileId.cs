using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class profileId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Jams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                columns: new[] { "EventDate", "ProfileId" },
                values: new object[] { new DateTime(2020, 8, 11, 12, 58, 57, 493, DateTimeKind.Local).AddTicks(6537), 1 });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                columns: new[] { "EventDate", "ProfileId" },
                values: new object[] { new DateTime(2020, 8, 11, 12, 58, 57, 498, DateTimeKind.Local).AddTicks(1723), 2 });

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                columns: new[] { "EventDate", "ProfileId" },
                values: new object[] { new DateTime(2020, 8, 11, 12, 58, 57, 498, DateTimeKind.Local).AddTicks(1894), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Jams");

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 7, 13, 51, 18, 620, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5903));
        }
    }
}
