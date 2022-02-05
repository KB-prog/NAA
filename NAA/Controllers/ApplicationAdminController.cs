using Forest.Controllers;
using NAA.Data.Models.Domain;
using NAA.Services.IService;
using NAA.Services.Models;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class ApplicationAdminController : Controller
    {
        private IApplicationService applicationService;
        private IUniversityService universityService;
        private ICourseService courseService;

        public ApplicationAdminController()
        {
            applicationService = new ApplicationService();
            universityService = new UniversityService();
            courseService = new CourseService();
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
                //return RedirectToAction("GetGenre", "Genre", new { id = musicGenreArtist.Genre});

            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationAdmin/Edit/5
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

        // GET: ApplicationAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationAdmin/Delete/5
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
