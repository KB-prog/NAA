using NAA.InServices.IService;
using NAA.InServices.Service;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class ServiceController : Controller
    {
        IInboundService service;
        private IUniversityService universityService;
        public ServiceController()
        {
            service = new InboundService();
            universityService = new UniversityService();
        }
        // GET: Service
        public ActionResult GetSHUCourses() 
        {
            return View(service.GetSHUCourses()); 
        }

        public ActionResult GetShefCourses()
        {
            return View(service.GetShefCourses());
        }

        public ActionResult GetUniversitiesCourses() 
        {
            return View(universityService.GetUniversities());
        }
        
        // GET: University/Details/5
        public ActionResult GetUniversityCourse(int id) 
        {
            return View(universityService.GetUniversity(id));
        }

        // GET: Service/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Service/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Service/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Service/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
