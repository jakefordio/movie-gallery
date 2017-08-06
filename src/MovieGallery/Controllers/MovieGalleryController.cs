using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{   //Controller classes need to be public for MVC to use them!
    public class MovieGalleryController : Controller
    {   //Action methods need to be public for MVC to find and use them!
        public ActionResult Detail()
        {
            ViewBag.Title = "Rogue One: A Star Wars Trilogy";
            ViewBag.Rated = "PG-13";
            ViewBag.Length = "2h 13m";
            ViewBag.Plot = "<p><b>Plot</b>: In a time of conflict, a group of unlikely heroes band together on a mission to steal the plans to the Death Star, the Empire’s ultimate weapon of destruction. This key event in the Star Wars timeline brings together ordinary people who choose to do extraordinary things, and in doing so, become part of something greater than themselves.</p>";
            ViewBag.Actors = new string[]
            {
                "Felicity Jones",
                "Diego Luna",
                "Alan Tudyk",
                "Donnie Yen",
                "Wen Jiang"
            };
            return View();
        }
    }
}