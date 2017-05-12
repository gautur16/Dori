using DoriVLN.Models.Entity;
using DoriVLN.Models.ViewModels;
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
        public List<FolderViewModel> getFoldersFromDBByUserID(int userID)
        {
            var result = _db.Folders.Where(f => f.ownerID == userID).ToList();
            List<FolderViewModel> temp = new List<FolderViewModel>();
            var files = _db.Files.Where(f => f.ownerID == userID);
            foreach (var item in result)
            {
                List<FileViewModel> tempList = new List<FileViewModel>();
                foreach (var file in files)
                {
                    if (file.parentFolderID == item.ID)
                    {
                        tempList.Add(new FileViewModel
                        {
                            name = file.name,
                            ownerID = file.ownerID,
                            fileType = file.fileType,
                            dateTime = file.dateTime,
                            content = file.content,
                            parentFolderID = file.parentFolderID,
                            ID = file.ID
                        });
                    }
                }
                    temp.Add(new FolderViewModel
                    {
                        name = item.name,
                        ID = item.ID,
                        fileList = tempList
                    });
            }
                return temp;
        }

        public Folder getFolderFromDB(int folderID)
        {
            var retFolder = _db.Folders.SingleOrDefault(f => f.ID == folderID);
            return retFolder;
        }

        public int getFolderID(Folder folder)
        {
            var retVal = _db.Folders.SingleOrDefault(f => f.name == folder.name && f.ownerID == folder.ownerID);
            int retID;
            if(retVal == null)
            {
                //TODO: throw exception...
            }
            retID = retVal.ID;
            return retID;
        }

        public bool folderExists(string folderName, int userID)
        {
            var retFolder = _db.Folders.SingleOrDefault(f => f.name == folderName && f.ownerID == userID);

            if(retFolder != null)
            {
                return true;
            }
            return false;
        }

       public int getUserIDByEmail(string email)
       {
            var result = _db.Users.SingleOrDefault(u => u.email == email);
            return result.ID;
       }


    }
}