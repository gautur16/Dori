using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.Entity
{
    public class Folder
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int ownerID { get; set; }
        public int parentFolderID { get; set; }
    }
}