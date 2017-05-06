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
            //TODO: How does one display the file's data from the database???

            return viewModel;
        }

        public void createFile(File file)
        {
            _fiDB.addFileToDB(file);
        }

        public void deleteFile(int fileID)
        {
            _fiDB.removeFileFromDB(fileID);
        }

        public void editFile(int fileID, FileViewModel file)
        {
            File editedFile = new File();
            editedFile.name = file.name;
            editedFile.fileType = file.fileType;
            _fiDB.editFileInDB(fileID, editedFile);
        }

        public bool fileExists(string fileName, string fileType)
        {
            return _fiDB.fileExists(fileName, fileType);
        }

        public File getFile(int fileID)
        {
            var file = _fiDB.getFileFromDB(fileID);
            return file;
        }
    }
}