using NAA.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IService
{
    public interface IUniversityService
    {
        IList<University> GetUniversities();
        IList<University> GetUniversitiesCourses(); 
        University GetUniversity(int id);
        IList<Application> GetApplications(int id); 
    }
}
