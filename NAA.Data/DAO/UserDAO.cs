using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class UserDAO : IUserDAO
    {     
        public void AddApplicationToCollection(Application application, string userId, NAAContext context)
        {
            context.Users.Find(userId).Applications.Add(application);
        }

        public void AddCourseToCollection(Course course, string userId, NAAContext context)
        {
            context.Users.Find(userId).Courses.Add(course);
        }

        public void AddUniversityToCollection(University university, string userId, NAAContext context)
        {
            context.Users.Find(userId).Universities.Add(university);
        }
    }
}
