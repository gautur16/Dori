using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.ViewModels
{
    public class EditorViewModel
    {
        public string Content { get; set; }
        public string fileName { get; set; }
        public string fileType { get; set; }
        public int fileID { get; set; }
    }
}