using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.Entity
{
    public class File
    {
        public int ID          { get; set; }
        public string name     { get; set; }
        public string fileType { get; set; }
        public int ownerID     { get; set; }
        //longText content 
        public string dateTime { get; set; }
        public int parentFolderID { get; set;}
    }
}