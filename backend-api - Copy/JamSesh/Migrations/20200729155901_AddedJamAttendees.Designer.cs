﻿// <auto-generated />
using System;
using JamSesh.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JamSesh.Migrations
{
    [DbContext(typeof(JamSeshContext))]
    [Migration("20200729155901_AddedJamAttendees")]
    partial class AddedJamAttendees
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JamSesh.Models.Jam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttendeesId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxNumberOfAttendees")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttendeesId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Jams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Need 2 more people to play some 80s Rock at Edgewater Park. Could use vocals and bass/guitar.",
                            EventDate = new DateTime(2020, 7, 29, 11, 59, 0, 234, DateTimeKind.Local).AddTicks(8997),
                            Image = "JamIcon.jpg",
                            Location = "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102",
                            MaxNumberOfAttendees = 3,
                            Name = "Acoustic Rock in the Park",
                            ProfileId = 1
                        });
                });

            modelBuilder.Entity("JamSesh.Models.JamAttendees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("JamAttendees");
                });

            modelBuilder.Entity("JamSesh.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JamAttendeesId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JamAttendeesId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "New to the area, and I just want to get together with some people on the weekends to play some tunes",
                            Image = "DefaultProfilePhoto.jpg",
                            Instruments = "Bass, Drums",
                            Location = "26635 Brookpark Rd, North Olmsted, OH 44070",
                            Name = "Brandon"
                        },
                        new
                        {
                            Id = 2,
                            Description = "I like playing jazz standards in small trios",
                            Image = "DefaultProfilePhoto.jpg",
                            Instruments = "Keys, Acoustic Guitar, Vocals",
                            Location = "7705 W Ridgewood Dr, Parma, OH 44129",
                            Name = "Eddie"
                        },
                        new
                        {
                            Id = 3,
                            Description = "I've got more instruments than just the ones I play. I'm usually available on the weekends. LET'S JAM",
                            Image = "DefaultProfilePhoto.jpg",
                            Instruments = "Mandalin, Guitar, Bass, Drums",
                            Location = "7415 Memphis Ave, Brooklyn, OH 44144",
                            Name = "Neil"
                        });
                });

            modelBuilder.Entity("JamSesh.Models.Jam", b =>
                {
                    b.HasOne("JamSesh.Models.JamAttendees", "Attendees")
                        .WithMany()
                        .HasForeignKey("AttendeesId");

                    b.HasOne("JamSesh.Models.Profile", "CreatorProfile")
                        .WithMany("JamsAttending")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JamSesh.Models.Profile", b =>
                {
                    b.HasOne("JamSesh.Models.JamAttendees", null)
                        .WithMany("Attendees")
                        .HasForeignKey("JamAttendeesId");
                });
#pragma warning restore 612, 618
        }
    }
}
