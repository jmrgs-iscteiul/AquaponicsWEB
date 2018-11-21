using AquaponicsWebPortal.DAL;
using AquaponicsWebPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AquaponicsWebPortal.Controllers
{
    public class HomeController : Controller
    {
        AquaponicsDbContext _context;

        public HomeController()
        {
            _context = new AquaponicsDbContext();

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var t = _context.Events.Where(x => x.Id == 3).FirstOrDefault();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}