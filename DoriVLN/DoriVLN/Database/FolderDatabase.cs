using DoriVLN.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Database
{
    public class FolderDatabase: BaseDatabase
    {
        public void addFolderToDB(Folder folder)
        {
            _db.Folders.Add(folder);
            _db.SaveChanges();
        }

        public void removeFolderFromDB()
        {

        }

        public void setFolderNameInDB()
        {

        }

        public Folder getFolderFromDB()
        {
            return null;
        }
    }
}