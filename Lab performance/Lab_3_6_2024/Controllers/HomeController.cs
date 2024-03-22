using Lab_3_6_2024.Dto;
using Lab_3_6_2024.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3_6_2024.Controllers
{
    public class HomeController : Controller
    {
        Lab_3_6_2024Entities db = new Lab_3_6_2024Entities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(userDto d)
        {
            var user = (from u in db.Users
                        where u.Username.Equals(d.Username)
                        && u.Password.Equals(d.Password)
                        select u).SingleOrDefault();
            if (user != null)
            {
                Session["user"] = user;
                if (user.Role.Equals("Admin"))
                {
                    return RedirectToAction("Index", "Admin");
                }

                return RedirectToAction("Index", "Order");

            }
            TempData["Msg"] = "Invalid username and password";

            return RedirectToAction("Index");

        }
    }
}