using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.Entity
{
    public class File
    {
        int ID          { get; set; }
        string name     { get; set; }
        string fileType { get; set; }
        int ownerID     { get; set; }
        //longText content 
        string dateTime { get; set; }
    }
}