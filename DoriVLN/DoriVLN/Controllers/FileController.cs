using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoriVLN.Models.ViewModels;

namespace DoriVLN.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult NewFile()
        {
            //TODO: implement
            return View();
        }

        public ActionResult TextEditor()
        {
            ViewBag.Code = "alert('Hello World!');";
            ViewBag.DocumentID = 17;
            return View();
        }
        
        [HttpPost]
        public ActionResult SaveCode(EditorViewModel model)
        {
            return View("File");
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