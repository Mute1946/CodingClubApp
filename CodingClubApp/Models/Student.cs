﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingClubApp.Models
{
    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int StudentID { get; set; }
        public int PhoneNum { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        
        //public ICollection<Request> Clubs { get; set; }
    }
}
