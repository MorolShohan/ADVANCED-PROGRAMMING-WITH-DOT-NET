using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        public List<Department> Get()
        {
            Sp24_CF_AEntities db = new Sp24_CF_AEntities();
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            return new Department { Id = id, Name = "dept" + id };
        }


    }
}
