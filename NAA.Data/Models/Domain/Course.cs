using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace NAA.Data.Models.Domain
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
