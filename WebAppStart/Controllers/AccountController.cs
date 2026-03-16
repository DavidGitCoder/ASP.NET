using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppStart.Models;

namespace WebAppStart.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            // if login model is validated then redirects to dashboard
            // otherwise return to the Login page/view
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View(model);
        }
    }
}