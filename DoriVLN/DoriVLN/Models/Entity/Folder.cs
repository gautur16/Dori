using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.Entity
{
    public class Folder
    {
        int ID { get; set; }
        string name { get; set; }
        int ownerID { get; set; }
    }
}