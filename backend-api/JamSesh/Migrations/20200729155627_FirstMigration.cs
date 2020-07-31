using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Instruments = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    MaxNumberOfAttendees = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jams_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "Location", "Name" },
                values: new object[] { 1, "New to the area, and I just want to get together with some people on the weekends to play some tunes", "DefaultProfilePhoto.jpg", "Bass, Drums", "26635 Brookpark Rd, North Olmsted, OH 44070", "Brandon" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "Location", "Name" },
                values: new object[] { 2, "I like playing jazz standards in small trios", "DefaultProfilePhoto.jpg", "Keys, Acoustic Guitar, Vocals", "7705 W Ridgewood Dr, Parma, OH 44129", "Eddie" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "Location", "Name" },
                values: new object[] { 3, "I've got more instruments than just the ones I play. I'm usually available on the weekends. LET'S JAM", "DefaultProfilePhoto.jpg", "Mandalin, Guitar, Bass, Drums", "7415 Memphis Ave, Brooklyn, OH 44144", "Neil" });

            migrationBuilder.InsertData(
                table: "Jams",
                columns: new[] { "Id", "Description", "EventDate", "Image", "Location", "MaxNumberOfAttendees", "Name", "ProfileId" },
                values: new object[] { 1, "Need 2 more people to play some 80s Rock at Edgewater Park. Could use vocals and bass/guitar.", new DateTime(2020, 7, 29, 11, 56, 27, 15, DateTimeKind.Local).AddTicks(2828), "JamIcon.jpg", "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102", 3, "Acoustic Rock in the Park", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Jams_ProfileId",
                table: "Jams",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jams");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
