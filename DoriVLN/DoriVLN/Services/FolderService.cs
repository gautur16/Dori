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

        public void deleteFolder(Folder folder)
        {
            var folderID = _foDB.getFolderID(folder);
                
        }

        public void setFolderName(string name, Folder folder)
        {
            int folderID = _foDB.getFolderID(folder);
            _foDB.setFolderNameInDB(folderID, name);
        }

        public bool folderExists(Folder folder)
        {
           return _foDB.folderExists(folder);
           
        }

        public FolderViewModel getFolder()
        {
            return null;
        }
    }
}