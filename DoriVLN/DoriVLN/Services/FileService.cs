﻿using DoriVLN.Models.Entity;
using DoriVLN.Models;
using DoriVLN.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoriVLN.Database;

namespace DoriVLN.Services
{
    public class FileService
    {
        private FileDatabase _fiDB;

        public FileService()
        {
            _fiDB = new FileDatabase();
        }

        public void createFile(FileViewModel model, int ownerID)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            File file = new File();
            file.fileType = model.fileType;
            file.ownerID = ownerID;
            file.name = model.name;
            file.dateTime = date;
            file.parentFolderID = model.parentFolderID;

            _fiDB.addFileToDB(file);
        }

        public List<File> getFiles(int userID)
        {
            return _fiDB.getFileFromDBByUserID(userID);
        }

        public void deleteFile(int fileID)
        {
            _fiDB.removeFileFromDB(fileID);
        }

        public bool fileExists(int userID, string fileName)
        {
            return _fiDB.fileExists(userID, fileName);
        }

        public int getFileID(FileViewModel model, int userID)
        {
            File file = new File();
            file.name = model.name;
            file.ownerID = userID;
            return _fiDB.getFileID(file);
        } 

        public int getUserIDByEmail(string email)
        {
            return _fiDB.getUserIDByEmail(email);
        }

        public void saveCode(EditorViewModel model, int userID, string name)
        {
            _fiDB.saveCode(userID, name, model);
        }

        public List<string> getFolderNamesOfUser(int userID)
        {
            return _fiDB.getFolderNamesOfUser(userID);
        } 

        public int getParentFolderIDByFolderName(int userID, string folderName)
        {
            return _fiDB.getParentFolderIDByFolderName(userID, folderName);
        }

        public void addShareRelation(int fileID, int userID)
        {
            _fiDB.addShareRelation(fileID, userID);
        }

        public int getFolderID(string name, int userID)
        {
            return _fiDB.getFolderID(name, userID);
        }

        public bool noFolder(int userID)
        {
            return _fiDB.noFolder(userID);
        }

        public List<FileViewModel> getFilesSharedWithMe(int userID)
        {
            return _fiDB.filesSharedWithMe(userID);
        }

        public bool userExists(string email)
        {
            return _fiDB.userExists(email);
        }
    }
}