using DoriVLN.Models.Entity;
using DoriVLN.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoriVLN.Models.ViewModels;

namespace DoriVLN.Database
{
    public class FileDatabase: BaseDatabase
    {
        public void addFileToDB(File file)
        {
            _db.Files.Add(file);
            _db.SaveChanges();
        }
        
        public File getFileFromDB(int fileID)
        {
            var retFile = _db.Files.SingleOrDefault(f => f.ID == fileID);
            return retFile;
        }


        public List<File> getFileFromDBByUserID(int userID)
        {
            var result = _db.Files.Where(u => u.ownerID == userID).ToList();
            return result;
        }


        public void removeFileFromDB(int fileID)
        {
            var file = _db.Files.SingleOrDefault(f => f.ID == fileID);
            if(file == null)
            {
                //TODO: Throw Null Exception
            }

            _db.Files.Attach(file);
            _db.Files.Remove(file);
            _db.SaveChanges();
        }

        public void  editFileInDB(File newfile)
        {
            var file = _db.Files.SingleOrDefault(f => f.ownerID == newfile.ownerID && f.name == newfile.name);

            file.name = newfile.name;
            file.fileType = newfile.fileType;
            file.content = newfile.content;
            _db.SaveChanges();

        }

        public bool fileExists(File file)
        {
            var retFile = _db.Files.SingleOrDefault(f => f.name == file.name && f.fileType == file.fileType && file.ownerID == f.ownerID);
            if(retFile != null)
            {
                return true;
            }

            return false;
        }

        public int getFileID(File file)
        {
            
            var retFile = _db.Files.SingleOrDefault(f => f.name == file.name && file.ownerID == f.ownerID);
            
            
                return retFile.ID;
            
        }

        public int getFileOwnerID(File file)
        {
            var retVal = _db.Files.SingleOrDefault(f => f.name == file.name && f.fileType == file.fileType);
            return retVal.ownerID;
        } 


        public string getUsername(int ID)
        {
            var result = _db.Users.SingleOrDefault(u => u.ID == ID);

            return result.username;
        }

        public int getUserIDByEmail(string email)
        {
            var result = _db.Users.SingleOrDefault(u => u.email == email);

            return result.ID;
        }

        public void saveCode(int userID, string name, EditorViewModel model)
        {
            var result = _db.Files.SingleOrDefault(f => f.ownerID == userID && f.name == name);

            result.content = model.Content;
            _db.SaveChanges();

        }

        public List<string> getFolderNamesOfUser(int userID)
        {
            List<string> retList = new List<string>();
            var result = _db.Folders.Where(f => f.ownerID == userID).ToList();

            foreach(var item in result)
            {
                retList.Add(item.name);
            }

            return retList;
        }

        public int getParentFolderIDByFolderName(int userID, string folderName)
        {
            var result = _db.Folders.SingleOrDefault(f => f.ownerID == userID && f.name == folderName);

            return result.ID;
        }

        public void addShareRelation(int fileID, int userID)
        {
            var result = _db.Files.SingleOrDefault(f => f.ID == fileID);
            result.shareID = userID;
            _db.SaveChanges();

        }
    }
}