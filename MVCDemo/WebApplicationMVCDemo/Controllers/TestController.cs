using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCDemo.Models;

namespace WebApplicationMVCDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            TempData["id"] = 1;
            TempData.Keep();

            ViewBag.Info1 = "bruce";
            ViewBag.Info2 = 56;

            List<Student> stdList = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Bruce", Department = "CS"},
                new Student(){ Id = 2, Name = "Clerk", Department = "EEE"},
                new Student(){ Id = 3, Name = "Diana", Department = "BBA"}
            };

            ViewBag.Std = stdList;

            return View();
        }

        public ActionResult M1()
        {
            //ViewData["info1"] = "bruce";
            ViewBag.data = TempData["id"];
            TempData.Keep();
            return View();
        }

        public ActionResult M2()
        {
            TempData["info1"] = "hello bruce";
            //TempData.Keep();
            return View();
        }

        public ActionResult M3()
        {
            ViewBag.info1 = TempData["info1"];
            return View();
        }

        
        public ActionResult M4()
        {
            return View();
        }
    }
}