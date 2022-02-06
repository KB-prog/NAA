using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IUserDAO
    {
        void AddApplicationToCollection(Application application, string userId, NAAContext context);
        void AddUniversityToCollection(University university, string userId, NAAContext context);
        void AddCourseToCollection(Course course, string userId, NAAContext context);
        void RemoveApplicationFromCollection(Application application, string userId, NAAContext context);
        void RemoveUniversityFromCollection(University university, string userId, NAAContext context);
        void RemoveCourseFromCollection(Course course, string userId, NAAContext context); 
    }
}
