using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{   //Controller classes need to be public for MVC to use them!
    public class MovieGalleryController : Controller
    {   //Action methods need to be public for MVC to find and use them!
        public string Detail()
        {
            return "Welcome to the mother fucking movie gallery bitch.";
        }
    }
}