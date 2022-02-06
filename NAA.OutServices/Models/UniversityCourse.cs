using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.OutServices.Models
{
    public class UniversityCourse
    {
        
        public UniversityCourse() { }
        public UniversityCourse(int courseId, string cName, string cDescription)
        {
            CourseID = courseId;
            Name = cName;
            Description = cDescription;
        }

        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
