using System.Web.Mvc;
using WebApplicationMVCDemo.Models;

namespace WebApplicationMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public string StudentInfo(int id, string firstName = "abc", double? cgpa = null)
        {
            return "Student Id: " + id + " Name: " + firstName + " Cgpa: " + cgpa;
        }

        public new ViewResult Profile()
        {
            return View();
        }

        public ActionResult StudentProfile()
        {

            Student data = new Student()
            {
                Id = 2,
                Name = "clerk",
                Department = "EEE"

            };

            return View(data);
        }


    }
}