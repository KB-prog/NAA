using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Models
{
    public class ApplicationUniversityCourse
    {
        public string Course { get; set; }
        public string Statement { get; set; }
        public string TeacherContact { get; set; }
        public string TeacherReference { get; set; }
        public int University { get; set; } // ID of the University
        public int CourseCode { get; set; } // ID of the Course
    }
}
