using LuckyPaw.Data;
using LuckyPaw.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataGraduates context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Graduates.Any())
            {
                return;   // DB has been seeded
            }

            var graduates = new Graduates[]
            {
            new Graduates{FirstMidName="Lily",LastName="Alexa",EnrollmentDate=DateTime.Parse("2007-10-01")},
            new Graduates{FirstMidName="Rudith",LastName="Reza",EnrollmentDate=DateTime.Parse("2012-08-15")},
            new Graduates{FirstMidName="Arthur",LastName="Zack",EnrollmentDate=DateTime.Parse("2010-11-12")},
            new Graduates{FirstMidName="Gyro",LastName="Raza",EnrollmentDate=DateTime.Parse("2016-03-09")},
            new Graduates{FirstMidName="Sasha",LastName="Lo",EnrollmentDate=DateTime.Parse("2014-07-06")},
            new Graduates{FirstMidName="Jecko",LastName="Coco",EnrollmentDate=DateTime.Parse("2011-12-16")},
            new Graduates{FirstMidName="Lois",LastName="Lala",EnrollmentDate=DateTime.Parse("2018-11-30")},
            new Graduates{FirstMidName="Dino",LastName="Saurus",EnrollmentDate=DateTime.Parse("2012-05-11")}
            };
            foreach (Graduates s in graduates)
            {
                context.Graduates.Add(s);
            }
            context.SaveChanges();

            var services = new Services[]
            {
            new Services{CourseID=1050,Title="Service Dog"},
            new Services{CourseID=4022,Title="Protection Dog"},
            new Services{CourseID=4041,Title="Protection Dog"},
            new Services{CourseID=1045,Title="Hunting Dog"},
            new Services{CourseID=3141,Title="General Obidiance"},
            new Services{CourseID=2021,Title="Theraphy Dog"},
            new Services{CourseID=2042,Title="Service Dog"}
            };
            foreach (Services c in services)
            {
                context.type.Add(c);
            }
            context.SaveChanges();

          
        }
    }
}