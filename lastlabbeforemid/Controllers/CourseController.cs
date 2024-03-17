using LabTask1.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        [HttpGet]
        public ActionResult course()
        {
            return View();
        }
        [HttpPost]
        public ActionResult course(courseTbl C)
        {
            var db = new labtaskEntities1();
            db.courseTbls.Add(C);
            db.SaveChanges();
            return View(C);
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}