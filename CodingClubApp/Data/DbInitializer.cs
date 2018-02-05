using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingClubApp.Models;


namespace CodingClubApp.Data
{
        public static class DbInitializer
        {
            public static void Initialize(ClubContext context)
            {
                context.Database.EnsureCreated();

                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                new Student{FName="Ryan",LName="Bentley",JoinDate=DateTime.Parse("2014-09-01")},
                new Student{FName="Tim",LName="Sellmyer",JoinDate=DateTime.Parse("2015-01-15")},
                new Student{FName="Brett",LName="Ponder",JoinDate=DateTime.Parse("2015-01-15")},
                new Student{FName="Sarah",LName="Billings",JoinDate=DateTime.Parse("2014-09-01")},
                };
                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();

                var teams = new Team[]
                {
                new Team{TeamName="Cannonball",TeamProject="CSI"},
                new Team{TeamName="Headsup",TeamProject="CSI"},
                new Team{TeamName="BountyHunters",TeamProject="CSI"},
                new Team{TeamName="LooseEnds",TeamProject="CSI"},
                };
                foreach (Team c in teams)
                {
                    context.Teams.Add(c);
                }
                context.SaveChanges();

                var joinclubs = new JoinClub[]
                {
                new JoinClub{StudentID=1,ClubID=2,TeamID=2},
                new JoinClub{StudentID=1,ClubID=1,TeamID=1},
                new JoinClub{StudentID=1,ClubID=3,TeamID=3},
                new JoinClub{StudentID=1,ClubID=4,TeamID=4},
                };
                foreach (JoinClub j in joinclubs)
                {
                    context.JoinClubs.Add(j);
                }
                context.SaveChanges();
            }
        }
}