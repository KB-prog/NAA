using NAA.Data.Models.Domain;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class UniversityController : Controller
    {
        private IUniversityService universityService;

        public UniversityController()
        {
            universityService = new UniversityService();
        }
        // GET: University
        public ActionResult GetUniversities() 
        {
            return View(universityService.GetUniversities());
        }

        // GET: University/Details/5
        public ActionResult GetUniversity(int id)
        {
            return View(universityService.GetUniversity(id));
        }

        public ActionResult GetApplications(int id)
        {
            IList<Application> application = universityService.GetApplications(id).ToList();
            return View(application); 
        }

        // GET: University/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: University/Create
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

        // GET: University/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: University/Edit/5
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

        // GET: University/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: University/Delete/5
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
