using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Models.Entity
{
    public class User
    {
        int ID          { get; set; }
        string name     { get; set; }
        string email    { get; set; }
        string username { get; set; }
        string password { get; set; }
    }
}