using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.InServices.IService
{
    public interface IInboundService
    {
        IList<NAA.InServices.ProxyToNAAWebService.SHUCourse> GetSHUCourses();
        IList<NAA.InServices.ProxyToNAASHEFWebService.ShefCourse> GetShefCourses(); 
    }
}
