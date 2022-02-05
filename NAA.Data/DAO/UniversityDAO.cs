using NAA.Data.IDAO;
using NAA.Data.Repository;
using NAA.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class UniversityDAO : IUniversityDAO
    {
        private NAAContext context;

        public UniversityDAO()
        {
            context = new NAAContext();
        }

        public void AddApplicationToCollection(Application application, University university, NAAContext context)
        {
            context.Univeristies.Find(university.UniversityId).Applications.Add(application);          
        }

        public IList<Application> GetApplications(int id, NAAContext context)
        {
            context.Univeristies.Include(m => m.Applications).ToList();           
            return context.Applications.ToList();
        }

        public IList<University> GetUniversities(NAAContext context) 
        {
            context.Univeristies.Include(g => g.Applications).ToList();
            return context.Univeristies.ToList();
        }

        public University GetUniversity(int id, NAAContext context)
        {
            context.Univeristies.Include(g => g.Applications).ToList();
            return context.Univeristies.Find(id);
        }
    }
}
