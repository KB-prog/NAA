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
            // User user1 = new User() { Name = "Rock" };
            // Genre genre2 = new Genre() { Name = "pop" };
            // Genre genre3 = new Genre() { Name = "Country" };
            // context.Genres.Add(genre1);
            // context.Genres.Add(genre2);
            // context.Genres.Add(genre3);

            //Creating University Objects
            University university1 = new University() { Name = "Sheffield Hallam University" };
            University university2 = new University() { Name = "Sheffield University" };
            context.Univeristies.Add(university1);
            context.Univeristies.Add(university2);

            //Creating Application Objects
            Application application1 = new Application()
            {
                Course = "Computer Science",
                Statement = "I want to be on this course",
                TeacherContact = "07125659458",
                TeacherReference = "Reference"
            };
            Application application2 = new Application()
            {
                Course = "Software Engineering",
                Statement = "I want to be on this Software Engineering course",
                TeacherContact = "07125659458",
                TeacherReference = "Reference"
            };

            context.Applications.Add(application1);
            context.Applications.Add(application2);

            //Creating Course Objects
            Course course1 = new Course()
            {
                Name = "Computer Science",
                Description = "Learning Programming Fundamentals"
            };
            Course course2 = new Course()
            {
                Name = "Software Engineering",
                Description = "Creating Enterprise Applications"
            };

            context.Courses.Add(course1);
            context.Courses.Add(course2);

            //Creating User Objects
            User user1 = new User() { UserID = "mo", Name = "Mo", Email = "mo@mo.com" };
            User user2 = new User() { UserID = "sam", Name = "Sam", Email = "sam@sam.com" };
            User user3 = new User() { UserID = "joe", Name = "Joe", Email = "joe@joe.com" };
            context.Users.Add(user1); context.Users.Add(user2); context.Users.Add(user3);
            context.SaveChanges();

        }
    }
}
