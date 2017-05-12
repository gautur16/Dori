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

        public bool folderExists(string folderName, int userID)
        {
            var retFolder = _db.Folders.SingleOrDefault(f => f.name == folderName && f.ownerID == userID);

            return retFolder != null;
        }

       public int getUserIDByEmail(string email)
       {
            var result = _db.Users.SingleOrDefault(u => u.email == email);

            return result.ID;
       }
    }
}