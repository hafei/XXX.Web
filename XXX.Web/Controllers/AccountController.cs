using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using XXX.Web.Interfaces;
using XXX.Web.Models;

namespace XXX.Web.Controllers
{
    public class AccountController : Controller
    {
        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model)
        {

            return View();
        }


        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}