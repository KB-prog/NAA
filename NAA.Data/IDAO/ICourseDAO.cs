using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface ICourseDAO
    {
        void AddApplicationToCollection(Application application, Course course, NAAContext context);
        Course GetCourse(int id, NAAContext context);
        IList<Course> GetCourses(NAAContext context); 
        Course GetCourse(Application application, NAAContext context); 
    }
}
