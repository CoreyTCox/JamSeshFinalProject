using JamSesh.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamSesh.Context
{
    public class JamSeshContext : DbContext
    {
        public DbSet<Jam> Jams { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=JamSeshDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<Profile>().HasData(

            new Profile
            {
                Id = 1,
                Name = "Brandon",
                Image = "DefaultProfilePhoto.jpg",
                Instruments = "Bass, Drums",
                Description = "New to the area, and I just want to get together with some people on the weekends to play some tunes",
                Location = "26635 Brookpark Rd, North Olmsted, OH 44070"
            },

            new Profile
            {
                Id = 2,
                Name = "Eddie",
                Image = "DefaultProfilePhoto.jpg",
                Instruments = "Keys, Acoustic Guitar, Vocals",
                Description = "I like playing jazz standards in small trios",
                Location = "7705 W Ridgewood Dr, Parma, OH 44129"
            },

            new Profile
            {
                Id = 3,
                Name = "Neil",
                Image = "DefaultProfilePhoto.jpg",
                Instruments = "Mandalin, Guitar, Bass, Drums",
                Description = "I've got more instruments than just the ones I play. I'm usually available on the weekends. LET'S JAM",
                Location = "7415 Memphis Ave, Brooklyn, OH 44144"
            }

            );

            modelbuilder.Entity<Jam>().HasData(
                new Jam
                {
                    Id = 1,
                    Name = "Acoustic Rock in the Park",
                    Location = "6500 Cleveland Memorial Shoreway, Cleveland, OH 44102",
                    Description = "Need 2 more people to play some 80s Rock at Edgewater Park. Could use vocals and bass/guitar.",
                    EventDate = DateTime.Now,
                    MaxNumberOfAttendees = 3,
                    Image = "JamIcon.jpg",
                    ProfileId = 1
                   
                   

                   
                }

                );
        }
    }
}
