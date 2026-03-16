using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        public ActionResult Index()
        {
            var customers = new CustomersListViewModel()
            {
                Customers = new List<Customer>
                {
                    new Customer { Name = "Sydney Fox" },
                    new Customer { Name = "Jack Reacher" },
                    new Customer { Name = "Jason Bourne" },
                    new Customer { Name = "Robin Hood" }
                }
            };
           

            return View(customers);
        }
    }
}