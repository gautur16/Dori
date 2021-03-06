﻿using DoriVLN.Models.Entity;
using DoriVLN.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoriVLN.Models.ViewModels;

namespace DoriVLN.Database
{
    public class FileDatabase : BaseDatabase
    {
        public void addFileToDB(File file)
        {
            _db.Files.Add(file);
            _db.SaveChanges();
        }

        public List<File> getFileFromDBByUserID(int userID)
        {
            var result = _db.Files.Where(u => u.ownerID == userID).ToList();
            return result;
        }


        public void removeFileFromDB(int fileID)
        {
            var file = _db.Files.SingleOrDefault(f => f.ID == fileID);
           
            _db.Files.Attach(file);
            _db.Files.Remove(file);
            _db.SaveChanges();
        }

        public bool fileExists(int userID, string fileName)
        {
            var retFile = _db.Files.SingleOrDefault(f => f.name == fileName && f.ownerID == userID);

            return retFile != null;
        }

        public int getFileID(File file)
        {
            var retFile = _db.Files.SingleOrDefault(f => f.name == file.name && file.ownerID == f.ownerID);

            return retFile.ID;
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
            result.dateTime = DateTime.Now;
            _db.SaveChanges();

        }

        public List<string> getFolderNamesOfUser(int userID)
        {
            List<string> retList = new List<string>();
            var result = _db.Folders.Where(f => f.ownerID == userID).ToList();

            foreach (var item in result)
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

        public int getFolderID(string name, int userID)
        {
            var retVal = _db.Folders.SingleOrDefault(f => f.name == name && f.ownerID == userID);

            return retVal.ID;
        }

        public bool noFolder(int userID)
        {
            var folders = _db.Folders.Where(f => f.ownerID == userID);

            return (folders == null);
        } 

        public List<FileViewModel> filesSharedWithMe(int userID)
        {
            var result = _db.Files.Where(f => f.shareID == userID);
            List<FileViewModel> temp = new List<FileViewModel>();
            foreach(var item in result)
            {
                temp.Add(new FileViewModel
                {
                    name = item.name,
                    fileType = item.fileType,
                    ownerID = item.ownerID,
                    dateTime = item.dateTime,
                    content = item.content,
                    parentFolderID = item.parentFolderID,
                    ID = item.ID
                });
            }
            return temp;
        }
        public bool userExists(string email)
        {
            var result = _db.Users.SingleOrDefault(u => u.email == email);

            return result == null;
        }
    }
}