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

        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("PageIndex = {0}, SortBy = {1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month) {
            return Content(String.Format("{0}/{1}", year, month));
        }
    }
}