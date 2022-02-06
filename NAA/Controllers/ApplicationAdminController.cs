using Forest.Controllers;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.IService;
using NAA.Services.Models;
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
    public class ApplicationAdminController : Controller
    {
        private IApplicationService applicationService;
        private IUniversityService universityService;
        private ICourseService courseService;
        private NAAContext context;

        public ApplicationAdminController()
        {
            applicationService = new ApplicationService();
            universityService = new UniversityService();
            courseService = new CourseService();
            context = new NAAContext();
        }
        // GET: ApplicationAdmin
        public ActionResult GetApplications()
        {
            return View(applicationService.GetApplications());
        }

        // GET: ApplicationAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationAdmin/Create
        public ActionResult AddApplication() 
        {
            Helper helper = new Helper();
            ViewBag.universityList = helper.GetUniversityDropDown();
            ViewBag.courseList = helper.GetCourseDropDown();
            return View();
        }

        // POST: ApplicationAdmin/Create
        [HttpPost]
        public ActionResult AddApplication(ApplicationUniversityCourse applicationUniversityCourse)
        {
            try
            {
                // 'mo' is the userId of a User in User table
                applicationService.AddApplication(applicationUniversityCourse, "mo");

                //Redirect to a different page/controller
                //return RedirectToAction("GetUniversities", "University");
                return RedirectToAction("GetApplications", "ApplicationAdmin");

            }
            catch
            {
                return View();
            }
        }

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
                return RedirectToAction("GetApplications", "ApplicationAdmin");
            }
            return View(application);
        }

        // GET: ApplicationAdmin/Delete/5
        public ActionResult DeleteApplication(int applicationId)
        {
            Application application = new Application();
            if (context.Applications.Any(x =>x.ApplicationID == applicationId && x.Offer == "Processing"))
            {
                return View(applicationService.GetApplication(applicationId));
            }
            else
            {
                TempData["AlertMessage"] = "You cannot Delete an Application that has already made an offer";
                return RedirectToAction("GetApplications", "ApplicationAdmin");
            }
        }

        // POST: ApplicationAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteApplication(int applicationId, Application application)  
        {
            try
            {            
               applicationService.DeleteApplication(applicationId, "mo");

               return RedirectToAction("GetApplications", "ApplicationAdmin");
                            
            }
            catch
            {
                return View();
            }
        }
    }
}
