using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodingClubApp.Models
{
    public class CodingClubAppContext : DbContext
    {
        public CodingClubAppContext (DbContextOptions<CodingClubAppContext> options)
            : base(options)
        {
        }

        public DbSet<CodingClubApp.Models.Student> Student { get; set; }
    }
}
