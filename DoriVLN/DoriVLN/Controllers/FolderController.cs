using DoriVLN.Database;
using DoriVLN.Models.Entity;
using DoriVLN.Models.ViewModels;
using DoriVLN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoriVLN.Controllers
{
    public class FolderController : Controller
    {
        private FolderService _foServ;
        public FolderController()
        {
            _foServ = new FolderService();
        }
        

        public ActionResult Overview()
        {
            return View(_foServ.getFolders());
        }
        public ActionResult RemoveFolder()
        {
            //TODO: implement
            return View();
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
                if (_foServ.folderExists(model))
                {
                    return View();
                }

                _foServ.createFolder(model);
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