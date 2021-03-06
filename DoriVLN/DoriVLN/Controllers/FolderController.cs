﻿using DoriVLN.Database;
using DoriVLN.Models.Entity;
using DoriVLN.Models.ViewModels;
using DoriVLN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace DoriVLN.Controllers
{
    [Authorize]
    public class FolderController : Controller
    {
        private FolderService _foServ;
        public FolderController()
        {
            _foServ = new FolderService();
        }

        public ActionResult Overview()
        {
            return View(_foServ.getFoldersByID(_foServ.getUserIDByEmail(User.Identity.GetUserName())));
        }

        [HttpGet]
        public ActionResult NewFolder()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult NewFolder(FolderViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_foServ.folderExists(model.name, _foServ.getUserIDByEmail(User.Identity.GetUserName())))
                {
                    ModelState.AddModelError("name","A folder with that name already exists.");
                    return View();
                }

                _foServ.createFolder(model, _foServ.getUserIDByEmail(User.Identity.GetUserName()));
                return RedirectToAction("Overview");
            } 
            return View();
        }

        public ActionResult DisplayFolders()
        {
            return View();
        }
    }
}