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
        

        public void createFolder(FolderViewModel folder, int ID)
        {
            Folder newFolder = new Folder();
            newFolder.name = folder.name;
            newFolder.ownerID = ID;

            _foDB.addFolderToDB(newFolder);
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

        public bool folderExists(FolderViewModel folder)
        {
            Folder checkFolder = new Folder();
            checkFolder.name = folder.name;

           return _foDB.folderExists(checkFolder);
           
        }

        public List<Folder> getFoldersByID(int ID)
        {
            return _foDB.getFoldersFromDBByUserID(ID);
        }

        public FolderViewModel getFolder()
        {
            return null;
        }

        public int getUserIDByEmail(string email)
        {
            return _foDB.getUserIDByEmail(email);
        }


    }
}