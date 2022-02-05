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
    public class CourseDAO : ICourseDAO
    {
        private NAAContext context;
        public CourseDAO()
        {
            context = new NAAContext();
        }
        public void AddApplicationToCollection(Application application, Course course, NAAContext context)
        {
            context.Courses.Find(course.CourseID).Applications.Add(application);
        }

        public Course GetCourse(Application application, NAAContext context)
        {
            context.Courses.Include(g => g.Applications).ToList();
            return context.Courses.Find(application); 
        }

        public IList<Course> GetCourses(NAAContext context)
        {
            context.Courses.Include(g => g.Applications).ToList();
            return context.Courses.ToList();
        }

        public Course GetCourse(int id, NAAContext context)
        {
            context.Courses.Include(g => g.Applications).ToList();
            return context.Courses.Find(id);
        }
    }
}
