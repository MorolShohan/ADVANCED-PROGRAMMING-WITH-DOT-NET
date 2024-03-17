
using IntroMVC.Models;
using System.Web.Mvc;


namespace IntroMVC.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            //
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Shohan";

            return View(s1);
        }
    }
}