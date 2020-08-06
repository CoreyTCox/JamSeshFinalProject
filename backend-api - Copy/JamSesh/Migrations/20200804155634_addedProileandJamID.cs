using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class addedProileandJamID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileJamID",
                table: "ProfileJams");

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 11, 56, 32, 999, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.InsertData(
                table: "ProfileJams",
                columns: new[] { "ProfileID", "JamID" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProfileJams",
                keyColumns: new[] { "ProfileID", "JamID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddColumn<int>(
                name: "ProfileJamID",
                table: "ProfileJams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2020, 8, 4, 11, 26, 12, 510, DateTimeKind.Local).AddTicks(7097));
        }
    }
}
