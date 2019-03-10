using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Hello world!" };
            return View(movie);
        }

        public ActionResult Edit(int id, string name) {
            return Content("Id = "+id+ ", Name = "+name);
        }
    }
}