using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingClubApp.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TeamName { get; set; }
        public string TeamProject { get; set; }

        //public ICollection<Request> Teams { get; set; }
    }
}
