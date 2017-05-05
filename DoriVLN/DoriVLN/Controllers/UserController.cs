using DoriVLN.Models.ViewModels;
using DoriVLN.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// using System.Web.Security;

namespace DoriVLN.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [AllowAnonymous]
        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(RegisterViewModel registerUser)
        {
            return View(registerUser);
        }

        public ActionResult ResetPassword()
        {
            //TODO: implement
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        // Remeber to change to LoginViewModel.
        [HttpPost]
        public ActionResult Login(UserViewModel loginUser)
        {
            return View(loginUser);
        }
    }
}