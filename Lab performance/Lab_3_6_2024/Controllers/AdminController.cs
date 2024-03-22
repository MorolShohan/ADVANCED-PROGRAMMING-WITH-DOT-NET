using Lab_3_6_2024.Dto;
using Lab_3_6_2024.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3_6_2024.Controllers
{
    public class AdminController : Controller
    {                
            // GET: Admin
            Lab_3_6_2024Entities db = new Lab_3_6_2024Entities();
            // GET: Order
            public ActionResult Index()
            {
                var data = db.Projects.ToList();
                return View(Convert(data));
            }


            public static projectDto Convert(Project p)
            {
                return new projectDto
                {
                   ProjectId = p.ProjectId,
                   Title = p.Title,
                   Description = p.Description,
                   ExpectedDeadline = p.ExpectedDeadline,
                };
            }
            public static Project Convert(projectDto p)
            {
                return new Project
                {
                    ProjectId= p.ProjectId,
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
            public ActionResult Accept(int id)
            {
                var od = db.Enrollments.Find(id);
                //from o in db.ProductOrders where o.Id = id
                //
                var data = od.Status;
               
                return RedirectToAction("Index");
            }
            public ActionResult Decline(int id)
            {
                var od = db.Enrollments.Find(id);
                od.Status = "Declined";
                db.SaveChanges();
                TempData["Msg"] = "Order Declined";
                return RedirectToAction("Index");
            }
        }
}