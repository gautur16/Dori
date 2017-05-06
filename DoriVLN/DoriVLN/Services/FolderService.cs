using DoriVLN.Database;
using DoriVLN.Models.Entity;
using DoriVLN.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Services
{
    public class FolderService
    {
        private FolderDatabase _foDB;

        public FolderService()
        {
            _foDB = new FolderDatabase();
        }
        

        public void createFolder(Folder folder)
        {
            _foDB.addFolderToDB(folder);
        }

        public void deleteFolder(FolderViewModel folder)
        {
            //TODO: Implement
        }

        public void setFolderName(string name, FolderViewModel folder)
        {
            //TODO: Implement
        }

        public bool folderExists(string folderName)
        {
            //TODO: Implement
            return false;
        }

        public FolderViewModel getFolder()
        {
            return null;
        }
    }
}