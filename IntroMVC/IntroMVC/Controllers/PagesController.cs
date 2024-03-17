using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Welcome()
        {

            string name = "Shohan Morol";
            int count = 35;
            var name2 = new int[] { };
            ViewBag.Name = name;
            ViewBag.Count = count;
            return View();
        }
        public ActionResult List()
        {
            //
            string[] names = new string[] { "niloy", "sakib", "shahos", "polash", "ayon", "rasel" };
            ViewBag.Names = names;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Submit()
        {
            //data retreive
            //vilidation
            //authentication
            TempData["Msg"] = "Login Successfull";
            return RedirectToAction("Index", "Dashboard");
        }

    }
}