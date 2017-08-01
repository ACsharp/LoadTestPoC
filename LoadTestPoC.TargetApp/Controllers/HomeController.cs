using LoadTestPoC.TargetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadTestPoC.TargetApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            using (var data = new MyData())
            {
                data.TargetEntities.Add(new MyTargetEntity { Id = id, CreatedOn = DateTime.Now });
                data.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}