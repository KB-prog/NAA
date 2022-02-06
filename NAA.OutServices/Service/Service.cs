using NAA.Data.Models.Domain;
using NAA.OutServices.IService;
using NAA.OutServices.Models;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.OutServices.Service
{
    public class Service : IContract
    {
        ICourseService courseService;
        IUniversityService universityService;

        public Service()
        {
            courseService = new CourseService();
            universityService = new UniversityService();
        }

        UniversityCourse[] GetCourses(IList<Course> courseList)
        {
            UniversityCourse[] list = new UniversityCourse[courseList.Count];

            for(int i = 0; i < list.Length; i++)
            {
                list[i] = new UniversityCourse
                {
                    CourseID = courseList[i].CourseID,
                    Name = courseList[i].Name,
                    Description = courseList[i].Description
                };
            }
            return list;
        }

        public UniversityCategories[] GetCourseCategories()
        {
            IList<University> universityList = universityService.GetUniversitiesCourses().ToList();
            UniversityCategories[] array = new UniversityCategories[universityList.Count];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new UniversityCategories
                {
                    UniversityId = universityList[i].UniversityId,
                    Name = universityList[i].Name,
                    Courses = GetCourses(universityList[i].Courses.ToList())
                };
            }
            return array;
        }

        public UniversityCourse[] GetUniCourses()
        {
            IList<Course> courseList = courseService.GetCourses().ToList();
            UniversityCourse[] array = new UniversityCourse[courseList.Count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new UniversityCourse
                {
                    CourseID = courseList[i].CourseID,
                    Name = courseList[i].Name,
                    Description = courseList[i].Description                    
                };
            }
            return array;
        }
    }
}
