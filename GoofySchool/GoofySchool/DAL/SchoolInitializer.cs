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
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01"), StudentPassword="alexanderpassword"},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2019-09-01"), StudentPassword="password"},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Now, StudentPassword="pasword"},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Now, StudentPassword="password"},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"), StudentPassword="password"},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"), StudentPassword="password"},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Now, StudentPassword="password"},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Now, StudentPassword="password"}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Goofy Flight Fundamental",Credits=3,},
            new Course{CourseID=4022,Title="Goofy Aerodynamics",Credits=3,},
            new Course{CourseID=4041,Title="Goofy Based Navigation",Credits=3,},
            new Course{CourseID=1045,Title="Goofy Math",Credits=4,},
            new Course{CourseID=3141,Title="Goofy Airline Operations",Credits=4,},
            new Course{CourseID=2021,Title="Goofy Landings",Credits=3,},
            new Course{CourseID=2042,Title="Goofy Decision Making",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}