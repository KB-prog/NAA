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
    public class ApplicationDAO : IApplicationDAO
    {
        private NAAContext context;

        public ApplicationDAO()
        {
            context = new NAAContext();
        }

        public void AddApplication(Application application, NAAContext context)
        {
            context.Applications.Add(application);
        }

        public void DeleteApplication(Application application, NAAContext context)
        {
            context.Applications.Remove(application);
        }

        public Application GetApplication(int id, NAAContext context)
        {
            context.Univeristies.Include(g => g.Applications).ToList();
            return context.Applications.Find(id);
        }

        public IList<Application> GetApplications(NAAContext context)
        {
            context.Univeristies.Include(g => g.Applications).ToList();
            return context.Applications.ToList();
        }
    }
}
