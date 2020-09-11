using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class AddedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 10, 8, 8, 129, DateTimeKind.Local).AddTicks(5679));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 3, 14, 4, 8, 767, DateTimeKind.Local).AddTicks(7424));
        }
    }
}
