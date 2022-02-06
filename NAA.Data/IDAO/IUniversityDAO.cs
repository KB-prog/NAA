using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IUniversityDAO
    {
        IList<University> GetUniversities(NAAContext context);  
        University GetUniversity(int id, NAAContext context);
        IList<Application> GetApplications(int id, NAAContext context);
        void AddApplicationToCollection(Application application, University university, NAAContext context);
        University GetUniversity(Application application, NAAContext context);
        void RemoveApplicationFromCollection(Application application, University university, NAAContext context); 
    }
}
