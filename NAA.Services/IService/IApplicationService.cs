using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IService
{
    public interface IApplicationService
    {
        Application GetApplication(int id);
        void AddApplication(ApplicationUniversityCourse applicationUniversityCourse, string userId);
        IList<Application> GetApplications();
        void DeleteApplication(int applicationId, string userId);  
    }
}
