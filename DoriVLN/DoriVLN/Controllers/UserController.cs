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
        public ActionResult NewUser()
        {
            
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
        
        [HttpPost]
        public ActionResult Login(User user)
        {
            return View(user);
        }
    }
}