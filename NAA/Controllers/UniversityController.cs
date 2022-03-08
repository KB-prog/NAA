using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    [Authorize(Roles = "University, Staff")]
    public class UniversityController : Controller
    {
        private IUniversityService universityService;
        private NAAContext context;
        public UniversityController()
        {
            universityService = new UniversityService();
            context = new NAAContext();
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
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = context.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: /Movies/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicationID,Course,Statement,TeacherContact,TeacherReference,Offer,Firm")] Application application) 
        {
            if (ModelState.IsValid)
            {
                context.Entry(application).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("GetUniversities", "University");
            }
            return View(application);
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
