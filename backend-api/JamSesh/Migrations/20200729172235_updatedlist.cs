using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class updatedlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 13, 22, 34, 737, DateTimeKind.Local).AddTicks(3744));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 11, 59, 0, 234, DateTimeKind.Local).AddTicks(8997));
        }
    }
}
