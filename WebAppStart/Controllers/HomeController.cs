using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppStart.Models;

namespace WebAppStart.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        // action method : public
        // regular method : protected
        [NonAction]
        public int Add(int x, int y)
        {
            return x + y;
        }

        public ViewResult Dashboard(LoginModel login)
        {
            return View(login);
        }
    }
}