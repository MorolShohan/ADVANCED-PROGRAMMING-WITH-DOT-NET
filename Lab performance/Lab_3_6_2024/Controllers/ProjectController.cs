using Lab_3_6_2024.Dto;
using Lab_3_6_2024.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3_6_2024.Controllers
{
    public class ProjectController : Controller
    {
        Lab_3_6_2024Entities db = new Lab_3_6_2024Entities();
        // GET: Project
        public ActionResult Index()
        {
            var data = db.Projects.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create()
        {
            var data = db.Projects.ToList();
            ViewBag.Categories = ProjectController.Convert(data);
            return View();
        }
        [HttpPost]
        public ActionResult Create(projectDto d)
        {
            if (ModelState.IsValid)
            {
                var data = Convert(d);
                db.Projects.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(d);
        }


        public static projectDto Convert(Project p)
        {
            return new projectDto
            {
                ProjectId = p.ProjectId,
                Title = p.Title,
                Description= p.Description,
                ExpectedDeadline = p.ExpectedDeadline,
            };
        }
        public static Project Convert(projectDto p)
        {
            return new Project
            {
                ProjectId = p.ProjectId,
                Title = p.Title,
                Description = p.Description,
                ExpectedDeadline = p.ExpectedDeadline,
            };
        }
        public static List<projectDto> Convert(List<Project> data)
        {
            var list = new List<projectDto>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;
        }
    }
}