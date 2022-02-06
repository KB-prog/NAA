using NAA.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.Repository
{
    public class NAAInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<NAAContext>
    {
        protected override void Seed(NAAContext context)
        {

            //Creating University Objects
            University university1 = new University() { Name = "Sheffield Hallam University" };
            University university2 = new University() { Name = "Sheffield University" };
            context.Univeristies.Add(university1);
            context.Univeristies.Add(university2);

            //Creating Application Objects
            Application application1 = new Application()
            {
                Course = "Computing",
                Statement = "I want to be on this course",
                TeacherContact = "07125659458",
                TeacherReference = "Reference",
                Offer = "Processing"
            };
            Application application2 = new Application()
            {
                Course = "Security",
                Statement = "I want to be on this Software Engineering course",
                TeacherContact = "07125659458",
                TeacherReference = "Reference",
                Offer = "Processing"
            };

            context.Applications.Add(application1);
            context.Applications.Add(application2);

            //Creating Course Objects
            Course course1 = new Course()
            {
                Name = "IT",
                Description = "Information Technology"
            };
            Course course2 = new Course()
            {
                Name = "Cyber Security",
                Description = "Develop information security skills"
            };
            Course course3 = new Course()
            {
                Name = "Security",
                Description = "Develop information security skills"
            };
            Course course4 = new Course()
            {
                Name = "Computing",
                Description = "Build Computing Applications"
            };
            Course course5 = new Course()
            {
                Name = "Computer Networks",
                Description = "Build Networks"
            };
            Course course6 = new Course()
            {
                Name = "Forensics",
                Description = "All about security"
            };

            context.Courses.Add(course1);
            context.Courses.Add(course2);
            context.Courses.Add(course3);
            context.Courses.Add(course4);
            context.Courses.Add(course5);
            context.Courses.Add(course6);

            //Creating User Objects
            User user1 = new User() { UserID = "mo", Name = "Mo", Email = "mo@mo.com" };
            User user2 = new User() { UserID = "sam", Name = "Sam", Email = "sam@sam.com" };
            User user3 = new User() { UserID = "joe", Name = "Joe", Email = "joe@joe.com" };
            context.Users.Add(user1); context.Users.Add(user2); context.Users.Add(user3);
            context.SaveChanges();

        }
    }
}
