using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.ViewModels
{
    public class FileViewModel
    {
        public string name { get; set; }
      //  public longtext content { get; set; }
        public string fileType { get; set; }
        public DateTime dateTime { get; set; }
    }
}