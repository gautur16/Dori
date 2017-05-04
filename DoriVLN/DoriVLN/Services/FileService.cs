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

        private ApplicationDbContext _db;
        private FileDatabase _fiDB;

        public FileService()
        {
            _db = new ApplicationDbContext();
            _fiDB = new FileDatabase();
        }

        public List<FileViewModel> getFilesInFolder(int folderID)
        {
            //TODO:
            return null;
        }

        public FileViewModel getFileByID(int fileID)
        {
            //TODO:
            //var file = _db.Files.SingleOrDefault(x => x.ID == fileID);
            /* if(file == null)
             {
                 //TODO: KASTA VILLU!
             }

             var viewModel = new FileViewModel
             {
                 name = file.name
             }; */

            var file = _fiDB.getFileFromDB(fileID);
            if (file == null)
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