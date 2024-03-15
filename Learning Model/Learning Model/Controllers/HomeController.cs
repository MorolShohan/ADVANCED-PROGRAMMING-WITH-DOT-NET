using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using Learning_Model.Models;

namespace Learning_Model.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }

        

        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Address = "Dhaka",
                Name = "SHOHAN"
            };
        }

    }
}