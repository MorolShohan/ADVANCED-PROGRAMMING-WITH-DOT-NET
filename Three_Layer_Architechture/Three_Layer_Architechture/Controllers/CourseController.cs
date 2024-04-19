using BLL.DTOs;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Three_Layer_Architechture.Controllers
{
    public class CourseController : ApiController
    {
        [HttpPost]
        [Route("api/course/create")]
        public HttpResponseMessage Create(CourseDTO c)
        {

            CourseService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpGet]
        [Route("api/course/all")]
        public HttpResponseMessage Get()
        {

            var data = CourseService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
