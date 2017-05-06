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

        public void removeFolderFromDB(int folderID)
        {
            var folder = _db.Folders.SingleOrDefault(f => f.ID == folderID);
            _db.Folders.Attach(folder);
            _db.Folders.Remove(folder);
            _db.SaveChanges();

        }

        public void setFolderNameInDB(int folderID, string newName)
        {
            var folder = _db.Folders.FirstOrDefault(f => f.ID == folderID);
            if(folder != null)
            {
                folder.name = newName;
                _db.SaveChanges();
            }

           
        }

        public Folder getFolderFromDB(int folderID)
        {
            var retFolder = _db.Folders.SingleOrDefault(f => f.ID == folderID);
            return retFolder;
        }

        public int getFolderID(File file)
        {
            var retID = _db.Folders.SingleOrDefault();

            return 0;
        }
    }
}