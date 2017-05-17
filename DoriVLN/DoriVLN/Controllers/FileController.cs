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
            List<SelectListItem> selectList = new List<SelectListItem>();
            List<string> values = _fiServ.getFolderNamesOfUser(_fiServ.getUserIDByEmail(User.Identity.GetUserName()));
            foreach (var item in values)
            {
                selectList.Add(new SelectListItem
                {
                    Text = item,
                    Value = item
                });
            }

            ViewBag.selectList = selectList;

            if (ModelState.IsValid)
            {
                if (_fiServ.noFolder(_fiServ.getUserIDByEmail(User.Identity.GetUserName())))
                {
                    ModelState.AddModelError("name", "Please create at least one folder before creating a file.");
                    return View();
                } 

                if(_fiServ.fileExists(_fiServ.getUserIDByEmail(User.Identity.GetUserName()), model.name))
                {
                    ModelState.AddModelError("name", "A file with that name already exists, please try again.");
                    return View();
                }
                model.parentFolderID = _fiServ.getParentFolderIDByFolderName(_fiServ.getUserIDByEmail(User.Identity.GetUserName()), model.folderName);
                model.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());
                _fiServ.createFile(model, _fiServ.getUserIDByEmail(User.Identity.GetUserName()));
                EditorViewModel tempModel = new EditorViewModel();
                tempModel.fileName = model.name;
                tempModel.fileType = model.fileType;
                tempModel.fileID = model.ID;
                tempModel.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());
                return RedirectToAction("TextEditor", tempModel);
            }

            return View();
        }

        public ActionResult TextEditor(EditorViewModel model)
        {
            ViewBag.Code = model.Content;
            ViewBag.DocumentID = model.fileID;
            if (model.fileType == "Javascript")
            {
                model.fileType = "javascript";
            }
            else if (model.fileType == "C++")
            {
                model.fileType = "c_cpp";
            }
            else if (model.fileType == "C#")
            {
                model.fileType = "csharp";
            }
            else if (model.fileType == "Java")
            {
                model.fileType = "java";
            }
            else if (model.fileType == "Python")
            {
                model.fileType = "python";
            }
            else if (model.fileType == "Ruby")
            {
                model.fileType = "ruby";
            }
            else if (model.fileType == "PHP")
            {
                model.fileType = "php";
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult SaveCode(EditorViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.fileName = TempData["fileName"].ToString();
                model.fileType = TempData["fileType"].ToString();
                model.ownerID = Convert.ToInt32(TempData["ownerID"]);
                _fiServ.saveCode(model, model.ownerID , model.fileName);
                if (model.fileType == "Javascript")
                {
                    model.fileType = "javascript";
                }
                else if (model.fileType == "C++")
                {
                    model.fileType = "c_cpp";
                }
                else if (model.fileType == "C#")
                {
                    model.fileType = "csharp";
                }
                else if (model.fileType == "Java")
                {
                    model.fileType = "java";
                }
                else if (model.fileType == "Python")
                {
                    model.fileType = "python";
                }
                else if (model.fileType == "Ruby")
                {
                    model.fileType = "ruby";
                }
                else if (model.fileType == "PHP")
                {
                    model.fileType = "php";
                } 
            }

            return RedirectToAction("TextEditor", model);
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
                if(_fiServ.userExists(model.email))
                {
                    ModelState.AddModelError("email", "No user exists with this email address");
                    return View();
                }
                FileViewModel temp = new FileViewModel();
                temp.name = model.fileToShare;
                temp.ownerID = _fiServ.getUserIDByEmail(User.Identity.GetUserName());

                _fiServ.addShareRelation(_fiServ.getFileID(temp, _fiServ.getUserIDByEmail(User.Identity.GetUserName())), _fiServ.getUserIDByEmail(model.email));

                return RedirectToAction("Overview", "Folder");
            }
            return View();
        }

        public ActionResult SharedFiles()
        {
            return View(_fiServ.getFilesSharedWithMe(_fiServ.getUserIDByEmail(User.Identity.GetUserName())));
        }
    }
}