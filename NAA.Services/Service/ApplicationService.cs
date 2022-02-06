using NAA.Data.DAO;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.IService;
using NAA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Service
{
    public class ApplicationService : IApplicationService
    {
        private IApplicationDAO applicationDAO;
        private IUniversityDAO universityDAO;
        private ICourseDAO courseDAO;
        private IUserDAO userDAO;
        public ApplicationService()
        {
            applicationDAO = new ApplicationDAO();
            universityDAO = new UniversityDAO();
            courseDAO = new CourseDAO();
            userDAO = new UserDAO();
        }

        public void AddApplication(ApplicationUniversityCourse applicationUniversityCourse, string userId)
        {
            Application newApplication = new Application() //Create new Music Object
            {
                Course = applicationUniversityCourse.Course,
                Statement = applicationUniversityCourse.Statement,
                TeacherContact = applicationUniversityCourse.TeacherContact,
                TeacherReference = applicationUniversityCourse.TeacherReference,
                Offer = "Processing",
                Firm = false

            };
            using (var context = new NAAContext())
            {
                //Context is created
                applicationDAO.AddApplication(newApplication, context); // Add Application
                University university = universityDAO.GetUniversity(applicationUniversityCourse.University, context); //Create Genre Object
                universityDAO.AddApplicationToCollection(newApplication, university, context); //Add Music to Collection of Genre
                Course course = courseDAO.GetCourse(applicationUniversityCourse.CourseCode, context); //Create Artist Object
                courseDAO.AddApplicationToCollection(newApplication, course, context); //Add Music to Collection of Artist
                userDAO.AddApplicationToCollection(newApplication, userId, context);
                context.SaveChanges();
            }
        }

        public void DeleteApplication(int applicationId, string userId)
        {
            using (var context = new NAAContext())
            {

                //Application application = applicationDAO.GetApplication(applicationId, context);
                //University university = universityDAO.GetUniversity(application, context);
                //universityDAO.RemoveApplicationFromCollection(application, university, context);
                //Course course = courseDAO.GetCourse(application, context);
                //courseDAO.RemoveApplicationFromCollection(application, course, context);
                //userDAO.RemoveApplicationFromCollection(application, userId, context);
                //applicationDAO.DeleteApplication(application, context);
                //context.SaveChanges();


                Application application = applicationDAO.GetApplication(applicationId, context);
                IList<University> ApplicationUniversityList = universityDAO.GetUniversities(context);
                foreach (University item in ApplicationUniversityList)
                {
                    if (item.Applications.Contains(application))
                    {
                        item.Applications.Remove(application);
                    }
                }
                IList<Course> courses = courseDAO.GetCourses(context);
                foreach (Course item in courses)
                {
                    if (item.Applications.Contains(application))
                    {
                        item.Applications.Remove(application);
                    }
                }
                userDAO.RemoveApplicationFromCollection(application, userId, context);
                applicationDAO.DeleteApplication(application, context);
                context.SaveChanges();
            }
        }

        public Application GetApplication(int id)
        {
            using (var context = new NAAContext())
            {
                return applicationDAO.GetApplication(id, context);
            }
        }

        public IList<Application> GetApplications()
        {
            using (var context = new NAAContext())
            {
                return applicationDAO.GetApplications(context);
            }
        }
    }
}
