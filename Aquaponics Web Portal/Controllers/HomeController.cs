using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aquaponics_Web_Portal.Models;
using AquaponicsWebPortal.EntityFramework.Entities;
using AquaponicsWebPortal.EntityFramework;

namespace Aquaponics_Web_Portal.Controllers
{
    public class HomeController : Controller
    {

        AquaponicsContext context;

        public HomeController()
        {
            this.context = new AquaponicsContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            Events ev = new Events();
            ev.Timestamp = DateTime.Now;
            ev.Event = 10;

            context.Events.Add(ev);
            context.SaveChanges();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
