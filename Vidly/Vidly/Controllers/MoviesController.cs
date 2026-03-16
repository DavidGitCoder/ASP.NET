using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" },
                new Customer { Name = "Customer3" },
                new Customer { Name = "Customer4" },
                new Customer { Name = "Customer5" },
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie= movie,
                Customers= customers,
            };
            return View(viewModel);

            //return View(movie);
            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home/Contact", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content($"id={id}");
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year:regex(\\d{4)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"Movies released in {month}/{year}");
        }

    }
}