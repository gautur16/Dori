using DoriVLN.Models.Entity;
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

        public List<FileViewModel> getFilesInFolder(int folderID)
        {
            //TODO:
            return null;
        }

        public FileViewModel getFileByID(int fileID)
        {
            var file = _fiDB.getFileFromDB(fileID);

            FileViewModel viewModel = new FileViewModel();
            viewModel.name = file.name;
            viewModel.fileType = file.fileType;
           // viewModel.owner = _fiDB.getUsername()
            //TODO: How does one display the file's data from the database???

            return viewModel;
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
 
        public void editFile(int userID, FileViewModel file)
        {
            File editedFile = new File();
            editedFile.name = file.name;
            editedFile.fileType = file.fileType;
            editedFile.content = file.content;
            editedFile.ownerID = userID;
            editedFile.dateTime = DateTime.Now;
            _fiDB.editFileInDB(editedFile);
        }

        public bool fileExists(File file)
        {
            return _fiDB.fileExists(file);
        }

        public File getFile(int fileID)
        {
            var file = _fiDB.getFileFromDB(fileID);
            return file;
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
    }
}