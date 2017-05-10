using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoriVLN.Models.ViewModels;
using DoriVLN.Services;
using Microsoft.AspNet.Identity;

namespace DoriVLN.Controllers
{
    public class FileController : Controller
    {
        private FileService _fiServ;

        public FileController()
        {
            _fiServ = new FileService();
        }
        // GET: File
        [HttpGet]
        public ActionResult NewFile()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult NewFile(FileViewModel model)
        {
            if (ModelState.IsValid)
            {
                _fiServ.createFile(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()));

                return RedirectToAction("TextEditor");
            }

            return View();
        }

        public ActionResult TextEditor()
        {
            ViewBag.Code = "//Hello there :) Welcome to your new file!";
            ViewBag.DocumentID = 17;
            return View();
        }

        /*public ActionResult Chat()
        {
            return View();
        }*/

        [HttpPost]
        public ActionResult SaveCode(EditorViewModel model)
        {
            return View("File");
        }


        public ActionResult DisplayFiles()
        {
            var result = _fiServ.getFiles(_fiServ.getUserIDByEmail(User.Identity.GetUserName()));
            return View(result);
        }

        public ActionResult RemoveFile()
        {
            //TODO: implement
            return View();
        }

        public ActionResult Share()
        {
            //TODO: implement
            return View();
        }
    }
}