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

        public void deleteFolder(int ID)
        {
           
            _foDB.removeFolderFromDB(ID); 
        }

        public void setFolderName(string name, Folder folder)
        {
            int folderID = _foDB.getFolderID(folder);
            _foDB.setFolderNameInDB(folderID, name);
        }

        public bool folderExists(string folderName, int userID)
        {
           

           return _foDB.folderExists(folderName, userID);
           
        }

        public List<FolderViewModel> getFoldersByID(int ID)
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


        public int getFolderID(FolderViewModel model, int userID)
        {
            Folder folder = new Folder();
            folder.name = model.name;
            folder.ownerID = userID;
            return _foDB.getFolderID(folder);
        }

    }
}