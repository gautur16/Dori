using DoriVLN.Models.Entity;
﻿using DoriVLN.Models;
using DoriVLN.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Services
{
    public class FileService
    {

        private ApplicationDbContext _db;

        public FileService()
        {
            _db = new ApplicationDbContext();
        }

        public List<FileViewModel> getFilesInFolder(int folderID)
        {
            //TODO:
            return null;
        }

        public FileViewModel getFileByID(int fileID)
        {
            //TODO:
            var file = _db.files.SingleOrDefault(x => x.ID == fileID);
            if(file == null)
            {
                //TODO: KASTA VILLU!
            }

            var viewModel = new FileViewModel
            {
                name = file.name
            };

            return viewModel;
        }

        public void createFile(File file)
        {
            //TODO: Implement
        }

        public void deleteFile(FileViewModel file)
        {
            //TODO: Implement
        }

        public void editFile(FileViewModel file)
        {
            //TODO: Implement
        }

        public bool fileExists(FileViewModel file)
        {
            //TODO: Implement
            return false;
        }

        public File getFile()
        {
            //TODO: Implement
            return null;
        }
    }
}