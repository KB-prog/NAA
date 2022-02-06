using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.OutServices.Models
{
    public class UniversityCategories
    {
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public UniversityCourse[] Courses { get; set; }
    }
}
