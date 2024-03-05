using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning_dotnet.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "hello from shohan";
        }

        public string Name()
        {
            return "My name is Shohan";
        }
    }
}