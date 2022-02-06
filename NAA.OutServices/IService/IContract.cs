using NAA.OutServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.OutServices.IService
{
    public interface IContract
    {
        UniversityCategories[] GetCourseCategories();
        UniversityCourse[] GetUniCourses();
    }
}
