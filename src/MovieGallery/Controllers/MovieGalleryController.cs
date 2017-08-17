using MovieGallery.Models;
using MovieGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{   //Controller classes need to be public for MVC to use them!
    public class MovieGalleryController : Controller
    {   //Action methods need to be public for MVC to find and use them!

        //underscore is a common convention for private fields
        private MovieRepository _movieRepository = null;

        public MovieGalleryController()
        {
            _movieRepository = new MovieRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _movieRepository.GetMovies();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var movie = _movieRepository.GetMovie((int)id);

            return View(movie);
        }

    }
}