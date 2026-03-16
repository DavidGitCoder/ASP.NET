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
        private readonly static List<Customer> _customers = new List<Customer>
        {
                new Customer { Name = "Sydney Fox", Id = 1 },
                new Customer { Name = "Jack Reacher", Id = 2 },
                new Customer { Name = "Jason Bourne", Id = 3 },
                new Customer { Name = "Robin Hood", Id = 4 }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customers = new CustomersListViewModel
            {
                Customers = _customers
            };
           

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _customers.Find(c => c.Id == id);
            if (customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}