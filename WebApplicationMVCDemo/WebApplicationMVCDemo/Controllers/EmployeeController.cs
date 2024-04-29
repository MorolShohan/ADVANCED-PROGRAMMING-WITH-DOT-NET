using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCDemo.Models;

namespace WebApplicationMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View();
            }

            return View("Index");
        }

        public ActionResult Test()
        {
            var d = GetData();
            return View();
        }

        public Employee GetData()
        {
            return new Employee()
            {
                Id = 1,
                Name = "diana",
                Salary = 10000,
                Email = "r@w.cv"
            };
        }
    }
}