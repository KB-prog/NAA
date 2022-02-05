using NAA.Data.DAO;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Service
{
    public class CourseService : ICourseService
    {
        private ICourseDAO courseDAO;
        private IUserDAO userDAO;

        public CourseService()
        {
            courseDAO = new CourseDAO();
            userDAO = new UserDAO();
        }
            
        public Course GetCourse(int id)
        {
            using (var context = new NAAContext())
            {
                return courseDAO.GetCourse(id, context);
            }
        }

        public IList<Course> GetCourses()
        {
            using (var context = new NAAContext())
            {
                return courseDAO.GetCourses(context);
            }
        }
    }
}
