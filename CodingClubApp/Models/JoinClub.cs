using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CodingClubApp.Models
{
    public class JoinClub
    {
        public int ClubID { get; set; }
        public int StudentID { get; set; }
        public int TeamID { get; set; }

        public Student Student { get; set; }
        public Team Team { get; set; }
    }
}
