using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 5, 8, 34, 55, 172, DateTimeKind.Local).AddTicks(2306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 10, 8, 8, 129, DateTimeKind.Local).AddTicks(5679));
        }
    }
}
