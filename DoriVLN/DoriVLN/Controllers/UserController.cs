﻿using DoriVLN.Models.ViewModels;
using DoriVLN.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoriVLN.Services;
// using System.Web.Security;

namespace DoriVLN.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private UserService _uServ;

        public UserController()
        {
            _uServ = new UserService();
        }

        // GET: User
        [HttpGet]
        [AllowAnonymous]
        public ActionResult RegisterUser()
        {
            RegisterViewModel newUser = new RegisterViewModel();
            return View(newUser);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult RegisterUser(RegisterViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                if (_uServ.usernameExists(registerUser))
                {
                    ModelState.AddModelError("username", "This username is taken.");
                    return View();
                }
                if (_uServ.emailExists(registerUser))
                {
                    ModelState.AddModelError("email", "This email is already in use.");
                    return View();
                }

                _uServ.addUser(registerUser);
                return RedirectToAction("Overview", "Folder");
            }
            
            return View(registerUser);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult ForgotPassword(ForgotPasswordViewModel forgotPassword)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }

            return View(forgotPassword);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            LoginViewModel loginUser = new LoginViewModel();
            return View(loginUser);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                if (_uServ.wrongPassword(loginUser))
                {
                    ModelState.AddModelError("username", " ");
                    return View();
                }


                return RedirectToAction("Overview", "Folder");
            }

            return View(loginUser);
        }
    }
}