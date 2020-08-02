using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GoofySchool.Models;

namespace GoofySchool.DAL
{

    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{Email="lagassemark@yahoo.com", Password="Testing1."},
            new Student{Email="aidalagasse@yahoo.com", Password="Testing1."},
            new Student{Email="frank@yahoo.com", Password="Testing1."},
            new Student{Email="shirley@yahoo.com", Password="Testing1."},
            new Student{Email="sabrina@yahoo.com", Password="Testing1."},
            new Student{Email="duke@yahoo.com", Password="Testing1."},
            new Student{Email="bellay@yahoo.com", Password="Testing1."},
            new Student{Email="uno@yahoo.com", Password="Testing1."}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Goofy Flight Fundamentals",FearFactor=3},
            new Course{CourseID=4022,Title="Goofy Landings",FearFactor=598,},
            new Course{CourseID=4041,Title="Goofy Ground Reference Maneuvers",FearFactor=256,},
            new Course{CourseID=1045,Title="Goofy Math for Pilots",FearFactor=1000,},
            new Course{CourseID=3141,Title="Goofy Pre-Flight Checks",FearFactor=2,},
            new Course{CourseID=2021,Title="Goofy Decision Making",FearFactor=3,},
            new Course{CourseID=2042,Title="Goofy Aerodyamics",FearFactor=2,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050},
            new Enrollment{StudentID=1,CourseID=4022},
            new Enrollment{StudentID=1,CourseID=4041},
            new Enrollment{StudentID=2,CourseID=1045},
            new Enrollment{StudentID=2,CourseID=3141},
            new Enrollment{StudentID=2,CourseID=2021},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022},
            new Enrollment{StudentID=5,CourseID=4041},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
