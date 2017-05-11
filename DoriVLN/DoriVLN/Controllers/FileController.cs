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
            List<SelectListItem> selectList = new List<SelectListItem>();
            List<string> values = _fiServ.getFolderNamesOfUser(_fiServ.getUserIDByEmail(User.Identity.GetUserName()));
            foreach(var item in values)
            {
                selectList.Add(new SelectListItem
                {
                    Text = item,
                    Value = item
                });
            }
           
            ViewBag.selectList = selectList;
            return View();
        }

        [HttpPost]
        public ActionResult NewFile(FileViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());
                _fiServ.createFile(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()));
                EditorViewModel tempModel = new EditorViewModel();
                tempModel.fileName = model.name;
                return RedirectToAction("TextEditor", tempModel);
            }



            return View();
        }

        public ActionResult TextEditor(EditorViewModel model)
        {
            ViewBag.Code = "//Hello there :) Welcome to your new file!";
            ViewBag.DocumentID = 17;

            return View(model);
        }

        /*public ActionResult Chat()
        {
            return View();
        }*/

        [HttpPost]
        public ActionResult SaveCode(EditorViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.fileName = TempData["fileName"].ToString();
                _fiServ.saveCode(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()) , model.fileName);
            }

            return RedirectToAction("Overview","Folder");
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

        [HttpPost]
        public ActionResult Edit(FileViewModel model)
        {
            if (ModelState.IsValid)
            {
                _fiServ.editFile(_fiServ.getUserIDByEmail(User.Identity.GetUserName()), model);
            }
            return View();
        }
    }
}