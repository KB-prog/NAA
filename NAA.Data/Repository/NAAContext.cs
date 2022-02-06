using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace NAA.Data.Repository
{
    public class NAAContext : DbContext
    {
        public NAAContext() : base("NAAContext")
        {
            Database.SetInitializer(new NAAInitialiser());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<University> Univeristies { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
