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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "COOL!" };

            return View(movie);
        }

        // Action Parameters
        public ActionResult Parameter(int id)
        {
            return Content("Movie Name: COOL, Movie Id: " + id);
        }

        // Optional Parameters
        public ActionResult Optional(int? page, string sortBy)
        {
            if (!page.HasValue)
                page = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("Optional Parameters are: page = {0}, sortBy = {1}", page, sortBy));
        }

        // Convention based Custom route: /movies/byreleasedate/{year}/{month}
        
        // Attribute routing

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}