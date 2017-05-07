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
            RegisterViewModel newUser = new RegisterViewModel();
            return View(newUser);
        }

        [HttpPost]
        public ActionResult RegisterUser(RegisterViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Overview", "Folder");
            }
            
            return View(registerUser);
        }

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordViewModel forgotPassword)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }

            return View(forgotPassword);
        }

        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel loginUser = new LoginViewModel();
            return View(loginUser);
        }
        
        [HttpPost]
        public ActionResult Login(LoginViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Overview", "Folder");
            }

            return View(loginUser);
        }
    }
}