using System;
using System.Collections.Generic;

namespace GoofySchool.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}