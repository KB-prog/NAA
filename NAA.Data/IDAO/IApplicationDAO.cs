using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IApplicationDAO
    {
        IList<Application> GetApplications(NAAContext context);
        Application GetApplication(int id, NAAContext context);
        void AddApplication(Application application, NAAContext context);
        void DeleteApplication(Application application, NAAContext context);
    }
}
