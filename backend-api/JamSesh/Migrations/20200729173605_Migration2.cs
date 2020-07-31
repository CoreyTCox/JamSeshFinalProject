using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 13, 36, 3, 474, DateTimeKind.Local).AddTicks(804));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 13, 22, 34, 737, DateTimeKind.Local).AddTicks(3744));
        }
    }
}
