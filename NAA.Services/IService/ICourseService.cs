using NAA.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IService
{
    public interface ICourseService
    {
        Course GetCourse(int id);
        IList<Course> GetCourses();
    }
}
