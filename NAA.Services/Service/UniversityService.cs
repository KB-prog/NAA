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
    public class UniversityService : IUniversityService
    {
        private IUniversityDAO universityDAO;
        private IUserDAO userDAO;
        public UniversityService()
        {
            universityDAO = new UniversityDAO();
            userDAO = new UserDAO();
        }

        public IList<Application> GetApplications(int id)
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetApplications(id, context);
            }
        }

        public IList<University> GetUniversities()
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetUniversities(context);
            }
        }

        public IList<University> GetUniversitiesCourses()
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetUniversitiesCourses(context); 
            }
        }

        public University GetUniversity(int id)
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetUniversity(id, context);
            }
        }
    }
}
