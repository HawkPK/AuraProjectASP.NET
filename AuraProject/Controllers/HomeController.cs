using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuraProject.Models;

namespace AuraProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public ActionResult About(string insertData)
        {
            ViewBag.Message = insertData;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult List()
        {
            return View(TechEquipment.GetElement());
        }
    }
}