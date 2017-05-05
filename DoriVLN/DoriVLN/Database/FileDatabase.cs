using DoriVLN.Models.Entity;
using DoriVLN.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Database
{
    public class FileDatabase: BaseDatabase
    {
        public void addFileToDB(File file)
        {
            _db.Files.Add(file);
            _db.SaveChanges();
        }
        
        public File getFileFromDB(int fileID)
        {
            //TODO: Implement
            return null;
        }

        public void removeFileFromDB()
        {
            //TODO: Implement
        }

        public void  editFileInDB()
        {

        }
    }
}