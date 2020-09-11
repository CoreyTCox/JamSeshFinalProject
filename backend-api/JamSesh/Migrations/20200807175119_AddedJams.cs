using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class AddedJams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                columns: new[] { "EventDate", "Location", "Name" },
                values: new object[] { new DateTime(2020, 8, 7, 13, 51, 18, 620, DateTimeKind.Local).AddTicks(5908), "333 Foundry St, Medina, OH 44256", "High Voltage Acoustic Rock" });

            migrationBuilder.InsertData(
                table: "Jams",
                columns: new[] { "JamId", "Description", "EventDate", "Image", "Location", "MaxNumberOfAttendees", "Name" },
                values: new object[,]
                {
                    { 2, "I need a lot of people and a pretty decent range of intruments so we can meet at castle noel and play Duke Ellington and Count Basie songs.", new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5766), "JamIcon.jpg", "260 S Court St, Medina, OH 44256", 7, "Castle Noel Big Band" },
                    { 3, "I need a drummer to play along with me while I play acoustic guitar and sing. Looking to play some popular gospel standards at my church this Sunday!", new DateTime(2020, 8, 7, 13, 51, 18, 625, DateTimeKind.Local).AddTicks(5903), "JamIcon.jpg", "606 E Washington St, Medina, OH 44256", 2, "Church Lot Duet" }
                });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "Location",
                value: "North Olmsted, OH");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2,
                column: "Location",
                value: "Parma, OH");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "Location",
                value: "Brooklyn, OH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1,
                columns: new[] { "EventDate", "Location", "Name" },
                values: new object[] { new DateTime(2020, 8, 5, 8, 34, 55, 172, DateTimeKind.Local).AddTicks(2306), "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102", "Acoustic Rock in the Park" });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "Location",
                value: "26635 Brookpark Rd, North Olmsted, OH 44070");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2,
                column: "Location",
                value: "7705 W Ridgewood Dr, Parma, OH 44129");

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "Location",
                value: "7415 Memphis Ave, Brooklyn, OH 44144");
        }
    }
}
