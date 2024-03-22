using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCDemo.Controllers
{
    public class LabController : Controller
    {
        public string Index()
        {
            return "Lab Con - Index";
        }

        public ActionResult Test()
        {
            return View("OurTest");
        }

        public ActionResult SharedAction()
        {
            return View();
        }

        public ActionResult MethodA()
        {
            return View();
        }

        public ActionResult MethodB()
        {
            return View();
        }
    }
}