using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DoriVLN.Models.ViewModels
{
    public class FolderViewModel
    {
        [Display(Name = "Folder Name")]
        public string name { get; set; }
        public int ownerID { get; set; }
        public int ID { get; set;  }
        public List<FileViewModel> fileList { get; set; }


    }
}