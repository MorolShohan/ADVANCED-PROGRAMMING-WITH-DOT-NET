using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies.Random
        public ActionResult Random()

        {
            var movie = new Movie()
            {
                Name = "Sherk!"
            };
            // return View(movie);
            // return Content("HELLO WORLD");
            return new EmptyResult();

        }

        public ActionResult Edit(int movieid)
        {
            return Content("Movie serial=" + movieid);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex ={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}