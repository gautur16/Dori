﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DoriVLN.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult NewUser()
        {
            //TODO: implement
            return View();
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

        /*
        [HttpPost]
        public ActionResult Login()
        {
            // TODO: implement functionality and add parameters.
            if (ModelState.IsValid)
            {

            }
        }
        */
    }
}