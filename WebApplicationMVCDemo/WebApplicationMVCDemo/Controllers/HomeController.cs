using System.Web.Mvc;

namespace WebApplicationMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to MVC";
        }

        public string Test()
        {
            return "Welcome to 3rd week";
        }

        public string Demo()
        {
            return "Welcome to 3rd week";
        }

        public string Info(int id)
        {
            return "Student Id: " + id;
        }

        public new ActionResult Profile()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }

        public ActionResult SharedAction()
        {
            return View();
        }
    }
}