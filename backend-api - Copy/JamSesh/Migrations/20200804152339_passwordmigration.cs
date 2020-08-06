using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamSesh.Migrations
{
    public partial class passwordmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jams_JamAttendees_AttendeesId",
                table: "Jams");

            migrationBuilder.DropForeignKey(
                name: "FK_Jams_Profiles_ProfileId",
                table: "Jams");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_JamAttendees_JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropTable(
                name: "JamAttendees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jams",
                table: "Jams");

            migrationBuilder.DropIndex(
                name: "IX_Jams_AttendeesId",
                table: "Jams");

            migrationBuilder.DropIndex(
                name: "IX_Jams_ProfileId",
                table: "Jams");

            migrationBuilder.DeleteData(
                table: "Jams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "JamAttendeesId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Jams");

            migrationBuilder.DropColumn(
                name: "AttendeesId",
                table: "Jams");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Jams");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "JamId",
                table: "Jams",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jams",
                table: "Jams",
                column: "JamId");

            migrationBuilder.CreateTable(
                name: "ProfileJams",
                columns: table => new
                {
                    JamID = table.Column<int>(nullable: false),
                    ProfileID = table.Column<int>(nullable: false),
                    ProfileJamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileJams", x => new { x.ProfileID, x.JamID });
                    table.ForeignKey(
                        name: "FK_ProfileJams_Jams_JamID",
                        column: x => x.JamID,
                        principalTable: "Jams",
                        principalColumn: "JamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileJams_Profiles_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jams",
                columns: new[] { "JamId", "Description", "EventDate", "Image", "Location", "MaxNumberOfAttendees", "Name" },
                values: new object[] { 1, "Need 2 more people to play some 80s Rock at Edgewater Park. Could use vocals and bass/guitar.", new DateTime(2020, 8, 4, 11, 23, 37, 798, DateTimeKind.Local).AddTicks(5838), "JamIcon.jpg", "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102", 3, "Acoustic Rock in the Park" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ProfileId", "Description", "Image", "Instruments", "Location", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "New to the area, and I just want to get together with some people on the weekends to play some tunes", "DefaultProfilePhoto.jpg", "Bass, Drums", "26635 Brookpark Rd, North Olmsted, OH 44070", "Brandon", "Welcome" },
                    { 2, "I like playing jazz standards in small trios", "DefaultProfilePhoto.jpg", "Keys, Acoustic Guitar, Vocals", "7705 W Ridgewood Dr, Parma, OH 44129", "Eddie", "Welcome" },
                    { 3, "I've got more instruments than just the ones I play. I'm usually available on the weekends. LET'S JAM", "DefaultProfilePhoto.jpg", "Mandalin, Guitar, Bass, Drums", "7415 Memphis Ave, Brooklyn, OH 44144", "Neil", "Welcome" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileJams_JamID",
                table: "ProfileJams",
                column: "JamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileJams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jams",
                table: "Jams");

            migrationBuilder.DeleteData(
                table: "Jams",
                keyColumn: "JamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "JamId",
                table: "Jams");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "JamAttendeesId",
                table: "Profiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Jams",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AttendeesId",
                table: "Jams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Jams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jams",
                table: "Jams",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "JamAttendees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JamAttendees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "JamAttendeesId", "Location", "Name", "Password" },
                values: new object[] { 1, "New to the area, and I just want to get together with some people on the weekends to play some tunes", "DefaultProfilePhoto.jpg", "Bass, Drums", null, "26635 Brookpark Rd, North Olmsted, OH 44070", "Brandon", "Welcome" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "JamAttendeesId", "Location", "Name", "Password" },
                values: new object[] { 2, "I like playing jazz standards in small trios", "DefaultProfilePhoto.jpg", "Keys, Acoustic Guitar, Vocals", null, "7705 W Ridgewood Dr, Parma, OH 44129", "Eddie", "Welcome" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Description", "Image", "Instruments", "JamAttendeesId", "Location", "Name", "Password" },
                values: new object[] { 3, "I've got more instruments than just the ones I play. I'm usually available on the weekends. LET'S JAM", "DefaultProfilePhoto.jpg", "Mandalin, Guitar, Bass, Drums", null, "7415 Memphis Ave, Brooklyn, OH 44144", "Neil", "Welcome" });

            migrationBuilder.InsertData(
                table: "Jams",
                columns: new[] { "Id", "AttendeesId", "Description", "EventDate", "Image", "Location", "MaxNumberOfAttendees", "Name", "ProfileId" },
                values: new object[] { 1, null, "Need 2 more people to play some 80s Rock at Edgewater Park. Could use vocals and bass/guitar.", new DateTime(2020, 8, 3, 14, 4, 8, 767, DateTimeKind.Local).AddTicks(7424), "JamIcon.jpg", "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102", 3, "Acoustic Rock in the Park", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_JamAttendeesId",
                table: "Profiles",
                column: "JamAttendeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Jams_AttendeesId",
                table: "Jams",
                column: "AttendeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Jams_ProfileId",
                table: "Jams",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jams_JamAttendees_AttendeesId",
                table: "Jams",
                column: "AttendeesId",
                principalTable: "JamAttendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jams_Profiles_ProfileId",
                table: "Jams",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_JamAttendees_JamAttendeesId",
                table: "Profiles",
                column: "JamAttendeesId",
                principalTable: "JamAttendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
