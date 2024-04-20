using BLL;
using BLL.BEnt;
using System.Collections.Generic;
using System.Web.Http;

namespace TierApp.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/Student/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return StudentService.GetNames();
        }
        [Route("api/Student/All")]
        [HttpGet]
        public List<StudentModel> GetAll()
        {

            return StudentService.Get();
        }

        [Route("api/Student/Create")]
        [HttpPost]
        public void Add(StudentModel s)
        {
            StudentService.Add(s);
        }
    }
}
