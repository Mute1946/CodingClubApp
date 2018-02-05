using CodingClubApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingClubApp.Data
{
    public class ClubContext : DbContext
    {
        public ClubContext(DbContextOptions<ClubContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<JoinClub> JoinClubs { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<JoinClub>().ToTable("JoinClubs");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
