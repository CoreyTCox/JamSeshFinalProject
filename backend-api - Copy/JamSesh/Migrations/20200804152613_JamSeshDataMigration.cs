using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class JamSeshDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 11, 26, 12, 510, DateTimeKind.Local).AddTicks(7097));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 11, 23, 37, 798, DateTimeKind.Local).AddTicks(5838));
        }
    }
}
