using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodingClubApp.Models
{
    public class Student
    {
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public int StudentID { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }
        public string Email { get; set; }
    }
}
