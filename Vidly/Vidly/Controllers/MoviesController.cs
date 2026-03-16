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
        public readonly static List<Movie> _movies = new List<Movie>()
        {
            new Movie{Id = 1, Name="Shrek"},
            new Movie{Id = 2, Name="Wall-e"},
            new Movie{Id = 3, Name="Finding Nemo"},
        };
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

        }

        public ActionResult Edit(int id)
        {
            return Content($"id={id}");
        }

        // movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
            
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        //}

        public ActionResult Index()
        {
            var movies = new MoviesListViewModel()
            {
                Movies = _movies
            };
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        [Route("movies/released/{year:regex(\\d{4)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"Movies released in {month}/{year}");
        }

    }
}