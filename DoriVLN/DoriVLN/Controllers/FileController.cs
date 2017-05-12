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
               /* if (_fiServ.noFolder(_fiServ.getUserIDByEmail(User.Identity.GetUserName())))
                {
                    ModelState.AddModelError("name", "Please create at least one folder before creating a file.");
                    return View();
                } */
                model.parentFolderID = _fiServ.getParentFolderIDByFolderName(_fiServ.getUserIDByEmail(User.Identity.GetUserName()), model.folderName);
                model.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());
                _fiServ.createFile(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()));
                EditorViewModel tempModel = new EditorViewModel();
                tempModel.fileName = model.name;
                tempModel.fileType = model.fileType;
                return RedirectToAction("TextEditor", tempModel);
            }



            return View();
        }

        public ActionResult TextEditor(EditorViewModel model)
        {
            ViewBag.Code = model.Content;
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

        public ActionResult Delete(FileViewModel model)
        {
            return View(model);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(FileViewModel model)
        {
            int ID = _fiServ.getFileID(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()));
            _fiServ.deleteFile(ID);
            return RedirectToAction("Overview", "Folder");
        }

        public ActionResult Share(ShareFileViewModel model)
        {
            if (ModelState.IsValid)
            {
                FileViewModel temp = new FileViewModel();
                temp.name = model.fileToShare;
                temp.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());

                _fiServ.addShareRelation(_fiServ.getFileID(temp, _fiServ.getUserIDByEmail(User.Identity.GetUserName())), _fiServ.getUserIDByEmail(model.email));

                return RedirectToAction("Overview", "Folder");
            }
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

        public ActionResult SharedFiles()
        {

            return View(_fiServ.getFilesSharedWithMe(_fiServ.getUserIDByEmail(User.Identity.GetUserName())));
        }
    }
}