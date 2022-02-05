using NAA.Data.Models.Domain;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forest.Controllers
{
    public class Helper
    {
        private IUniversityService universityService;
        private IApplicationService applicationService;
        private ICourseService courseService; 
        public Helper()
        {
            universityService = new UniversityService();
            applicationService = new ApplicationService();
            courseService = new CourseService();
        }
         
        public List<SelectListItem> GetUniversityDropDown() 
        {
            List<SelectListItem> universityList = new List<SelectListItem>();
            IList<University> universities = universityService.GetUniversities();
            
            foreach(var item in universities)
            {
                universityList.Add
                    (
                        new SelectListItem()
                        {
                            Text = item.Name,
                            Value = item.UniversityId.ToString(),
                            Selected = (item.Name == (universities[0].Name) ? true : false)
                        }
                    );
            }
            return universityList;
        }

        public List<SelectListItem> GetCourseDropDown() 
        {
            List<SelectListItem> courseList = new List<SelectListItem>();
            IList<Course> courses = courseService.GetCourses();

            foreach (var item in courses)
            {
                courseList.Add
                    (
                        new SelectListItem()
                        {
                            Text = item.Name,
                            Value = item.CourseID.ToString(),
                            Selected = (item.Name == (courses[0].Name) ? true : false)
                        }
                    );
            }
            return courseList;
        }
    }
}