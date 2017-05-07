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
        [HttpPost]
        public ActionResult NewFolder(FolderViewModel model)
        {
            if (ModelState.IsValid)
            {
                /*Scientist newScientist = new Scientist();
                newScientist.Name = model.Name;
                newScientist.BirthDate = model.BirthDate;
                newScientist.Computer = db.Computers.Where(x => x.ID == model.ComputerID).SingleOrDefault();

                db.Scientists.Add(newScientist);
                db.SaveChanges(); */

                Folder newFolder = new Folder();
                newFolder.name = model.name;
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult DisplayFolders()
        {
            return View();
        }
    }
}