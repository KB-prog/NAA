using NAA.InServices.IService;
using NAA.InServices.ProxyToNAASHEFWebService;
using NAA.InServices.ProxyToNAAWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.InServices.Service
{
    public class InboundService : IInboundService
    {
        SHUWebServiceSoapClient proxy;
        SheffieldWebServiceSoapClient proxySheff;
        public InboundService()
        {
            //Create 'proxy' object
            proxy = new SHUWebServiceSoapClient("SHUWebServiceSoap", "http://webteach_net.hallam.shu.ac.uk/cmsmr2/SHUWebService.asmx");
            proxySheff = new SheffieldWebServiceSoapClient("SheffieldWebServiceSoap", "http://webteach_net.hallam.shu.ac.uk/cmsmr2/SheffieldWebService.asmx");
        }

        public IList<ShefCourse> GetShefCourses()
        {
            return proxySheff.SheffCourses();
        }

        public IList<SHUCourse> GetSHUCourses() 
        {
            return proxy.SheffCourses();
        }

    }
}
