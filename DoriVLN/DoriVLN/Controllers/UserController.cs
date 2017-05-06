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
        [HttpGet]
        [AllowAnonymous]
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegisterViewModel registerUser)
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