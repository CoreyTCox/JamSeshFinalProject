using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Profiles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 3, 14, 4, 8, 767, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Welcome");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Welcome");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "Welcome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 7, 29, 13, 36, 3, 474, DateTimeKind.Local).AddTicks(804));
        }
    }
}
